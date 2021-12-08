using System;
using System.Collections.Generic;
using System.Linq;
using Crestron.SimplSharpPro.DeviceSupport;
using Crestron.SimplSharpPro;

namespace CBLINK
{
    /// <summary>
    /// 11
    /// </summary>
    public interface IPinpad
    {
        object UserObject { get; set; }

        event EventHandler<UIEventArgs> N1;
        event EventHandler<UIEventArgs> N2;
        event EventHandler<UIEventArgs> N3;
        event EventHandler<UIEventArgs> N4;
        event EventHandler<UIEventArgs> N5;
        event EventHandler<UIEventArgs> N6;
        event EventHandler<UIEventArgs> N7;
        event EventHandler<UIEventArgs> N8;
        event EventHandler<UIEventArgs> N9;
        event EventHandler<UIEventArgs> N10;
        event EventHandler<UIEventArgs> N11;

        void User(PinpadBoolInputSigDelegate callback);
        void Admin(PinpadBoolInputSigDelegate callback);
        void Dialog(PinpadStringInputSigDelegate callback);

    }

    public delegate void PinpadBoolInputSigDelegate(BoolInputSig boolInputSig, IPinpad pinpad);
    public delegate void PinpadStringInputSigDelegate(StringInputSig stringInputSig, IPinpad pinpad);

    internal class Pinpad : IPinpad, IDisposable
    {
        #region Standard CH5 Component members

        private ComponentMediator ComponentMediator { get; set; }

        public object UserObject { get; set; }

        public uint ControlJoinId { get; private set; }

        private IList<BasicTriListWithSmartObject> _devices;
        public IList<BasicTriListWithSmartObject> Devices { get { return _devices; } }

        #endregion

        #region Joins

        private static class Joins
        {
            internal static class Booleans
            {
                public const uint N1 = 1;
                public const uint N2 = 2;
                public const uint N3 = 3;
                public const uint N4 = 4;
                public const uint N5 = 5;
                public const uint N6 = 6;
                public const uint N7 = 7;
                public const uint N8 = 8;
                public const uint N9 = 9;
                public const uint N10 = 10;
                public const uint N11 = 11;

                public const uint User = 1;
                public const uint Admin = 2;
            }
            internal static class Strings
            {

                public const uint Dialog = 1;
            }
        }

        #endregion

        #region Construction and Initialization

        internal Pinpad(ComponentMediator componentMediator, uint controlJoinId)
        {
            ComponentMediator = componentMediator;
            Initialize(controlJoinId);
        }

        private void Initialize(uint controlJoinId)
        {
            ControlJoinId = controlJoinId; 
 
            _devices = new List<BasicTriListWithSmartObject>(); 
 
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.N1, onN1);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.N2, onN2);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.N3, onN3);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.N4, onN4);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.N5, onN5);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.N6, onN6);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.N7, onN7);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.N8, onN8);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.N9, onN9);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.N10, onN10);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.N11, onN11);

        }

        public void AddDevice(BasicTriListWithSmartObject device)
        {
            Devices.Add(device);
            ComponentMediator.HookSmartObjectEvents(device.SmartObjects[ControlJoinId]);
        }

        public void RemoveDevice(BasicTriListWithSmartObject device)
        {
            Devices.Remove(device);
            ComponentMediator.UnHookSmartObjectEvents(device.SmartObjects[ControlJoinId]);
        }

        #endregion

        #region CH5 Contract

        public event EventHandler<UIEventArgs> N1;
        private void onN1(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = N1;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> N2;
        private void onN2(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = N2;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> N3;
        private void onN3(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = N3;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> N4;
        private void onN4(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = N4;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> N5;
        private void onN5(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = N5;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> N6;
        private void onN6(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = N6;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> N7;
        private void onN7(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = N7;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> N8;
        private void onN8(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = N8;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> N9;
        private void onN9(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = N9;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> N10;
        private void onN10(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = N10;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> N11;
        private void onN11(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = N11;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }


        public void User(PinpadBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.User], this);
            }
        }

        public void Admin(PinpadBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Admin], this);
            }
        }


        public void Dialog(PinpadStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Dialog], this);
            }
        }

        #endregion

        #region Overrides

        public override int GetHashCode()
        {
            return (int)ControlJoinId;
        }

        public override string ToString()
        {
            return string.Format("Contract: {0} Component: {1} HashCode: {2} {3}", "Pinpad", GetType().Name, GetHashCode(), UserObject != null ? "UserObject: " + UserObject : null);
        }

        #endregion

        #region IDisposable

        public bool IsDisposed { get; set; }

        public void Dispose()
        {
            if (IsDisposed)
                return;

            IsDisposed = true;

            N1 = null;
            N2 = null;
            N3 = null;
            N4 = null;
            N5 = null;
            N6 = null;
            N7 = null;
            N8 = null;
            N9 = null;
            N10 = null;
            N11 = null;
        }

        #endregion

    }
}
