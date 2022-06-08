﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Chimera
{
    /// <summary>
    /// Provides the glue so that an event can be fired when
    /// a particular key combination is pressed.
    /// 
    /// It is best to think of the HotKey as being associated 
    /// with the action to be performed rather than the key
    /// combination, although both can be changed during the
    /// life of the HotKey. 
    /// </summary>
    public class HotKey : IMessageFilter, IDisposable
    {
        /// <summary>
        /// Definition required for delegates that want to be notified 
        /// when the hot key has been pressed.
        /// </summary>
        public delegate void HotKeyHandler();

        /// <summary>
        /// Event that will be fired when the hot key has been pressed.
        /// </summary>
        public event HotKeyHandler HotKeyPressed;

        private KeyCombo hotKeyCombo;
        /// <summary>
        /// The KeyCombo that we will be using as the hotkey.
        /// </summary>
        public KeyCombo HotKeyCombo
        {
            get { return hotKeyCombo; }
        }

        private Form form;
        private int id;
        private bool isRegistered;

        //private bool isDisposed;

        /// <summary>
        /// Constructor that initialises the hotkey and provides its identity.
        /// The hot key will not actually be registered until RegisterHotKey() is called.
        /// </summary>
        /// <param name="hotKeyCombo">Initial hot key combination to use</param>
        /// <param name="form">Window to receive hot key as required by Win32 API</param>
        /// <param name="id">An ID for the hot key as required by the Win32 API</param>
        public HotKey(Form form, int id)
        {
            this.form = form;
            this.id = id;

            // we need to monitor the messages so we know when the hotkey is pressed
            Application.AddMessageFilter(this);
        }

        ~HotKey()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Cleans up 
        /// </summary>
        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                // no managed objects to dispose
            }
            // make sure hot key is not registered
            UnRegisterHotKey();
            // and remove us from the message filter
            Application.RemoveMessageFilter(this);
        }

        /// <summary>
        /// Registers the hot key with Windows.
        /// If another key combo was registered, then this will be de-registered first.
        /// </summary>
        /// <param name="keyCombo">The new key combo to register with the hotey</param>
        /// <returns>true if the hot key was accepted.  
        /// false indicates new keyCombo was not accepted, but previous state
        /// of the hot key should have been restored.</returns>
        public bool RegisterHotKey(KeyCombo keyCombo)
        {
            if (form == null)
            {
                throw new ApplicationException("HotKey must be associated with a form before registering");
            }
            if (form.Handle == IntPtr.Zero)
            {
                throw new ApplicationException("HotKey must be associated with a window before registering");
            }

            if (isRegistered)
            {
                UnRegisterHotKey();
            }

            /* TEST */
            keyCombo.Enabled = true;
            keyCombo.FromPropertyValue(0x00060027);
            

            if (keyCombo.Enabled)
            {
                isRegistered = Win32.RegisterHotKey(form.Handle, id,
                                                    keyCombo.Win32Modifier,
                                                    keyCombo.Win32KeyCode);
                if (isRegistered)
                {
                    hotKeyCombo = keyCombo;
                    // new key combinaton as been succesfully registered as a hotkey
                    return true;
                }
                else
                {
                    // failed to register new key combo 
                    // - probably because it's already registered as a hotkey
                    if (hotKeyCombo.Enabled)
                    {
                        // re-register old key combo to return to the state we were in when called
                        isRegistered = Win32.RegisterHotKey(form.Handle, id,
                                                    hotKeyCombo.Win32Modifier,
                                                    hotKeyCombo.Win32KeyCode);
                        // above should not fail 
                        // but if it does, there is not much we can do about it
                    }
                    // failed to register new key combination as hot key
                    return false;
                }
            }
            else
            {
                // as the key asked to be disabled
                // isRegistered will be false,
                // but we return true as we have done what we were asked to do
                isRegistered = false;
                hotKeyCombo = keyCombo;
                return true;
            }
        }

        /// <summary>
        /// Unregisters the hot key with windows.
        /// </summary>
        public void UnRegisterHotKey()
        {
            if (isRegistered)
            {
                if (Win32.UnregisterHotKey(form.Handle, id))
                {
                    isRegistered = false;
                }
            }
        }

        /// <summary>
        /// Our filter to check if we have been told that our hot key has been pressed.
        /// If so, the HotKeyPressed event is fired.
        /// </summary>
        /// <param name="m">The windows message</param>
        /// <returns>false, to allow the message to be dispatched.</returns>
        public bool PreFilterMessage(ref Message m)
        {
            if (m.Msg == Win32.WM_HOTKEY)
            {
                if ((int)m.WParam == id)
                {
                    if (HotKeyPressed != null)
                    {
                        HotKeyPressed();
                    }
                }
            }
            return false; // allow message to be dispatched
        }
    }
}
