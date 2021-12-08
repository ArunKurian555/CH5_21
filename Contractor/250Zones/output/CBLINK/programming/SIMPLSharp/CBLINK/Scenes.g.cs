using System;
using System.Collections.Generic;
using System.Linq;
using Crestron.SimplSharpPro.DeviceSupport;
using Crestron.SimplSharpPro;

namespace CBLINK
{
    public interface IScenes
    {
        object UserObject { get; set; }

        event EventHandler<UIEventArgs> Scenes0;
        event EventHandler<UIEventArgs> Scenes1;
        event EventHandler<UIEventArgs> Scenes2;
        event EventHandler<UIEventArgs> Scenes3;
        event EventHandler<UIEventArgs> Scenes4;
        event EventHandler<UIEventArgs> Scenes5;
        event EventHandler<UIEventArgs> Scenes6;
        event EventHandler<UIEventArgs> Scenes7;
        event EventHandler<UIEventArgs> Scenes8;
        event EventHandler<UIEventArgs> Scenes9;
        event EventHandler<UIEventArgs> Scenes10;
        event EventHandler<UIEventArgs> Scenes11;
        event EventHandler<UIEventArgs> Scenes12;
        event EventHandler<UIEventArgs> Scenes13;
        event EventHandler<UIEventArgs> Scenes14;
        event EventHandler<UIEventArgs> Scenes15;
        event EventHandler<UIEventArgs> Raise;
        event EventHandler<UIEventArgs> Lower;

        void Scenefb0(ScenesBoolInputSigDelegate callback);
        void Scenefb1(ScenesBoolInputSigDelegate callback);
        void Scenefb2(ScenesBoolInputSigDelegate callback);
        void Scenefb3(ScenesBoolInputSigDelegate callback);
        void Scenefb4(ScenesBoolInputSigDelegate callback);
        void Scenefb5(ScenesBoolInputSigDelegate callback);
        void Scenefb6(ScenesBoolInputSigDelegate callback);
        void Scenefb7(ScenesBoolInputSigDelegate callback);
        void Scenefb8(ScenesBoolInputSigDelegate callback);
        void Scenefb9(ScenesBoolInputSigDelegate callback);
        void Scenefb10(ScenesBoolInputSigDelegate callback);
        void Scenefb11(ScenesBoolInputSigDelegate callback);
        void Scenefb12(ScenesBoolInputSigDelegate callback);
        void Scenefb13(ScenesBoolInputSigDelegate callback);
        void Scenefb14(ScenesBoolInputSigDelegate callback);
        void Scenefb15(ScenesBoolInputSigDelegate callback);
        void ScenesName0(ScenesStringInputSigDelegate callback);
        void ScenesName1(ScenesStringInputSigDelegate callback);
        void ScenesName2(ScenesStringInputSigDelegate callback);
        void ScenesName3(ScenesStringInputSigDelegate callback);
        void ScenesName4(ScenesStringInputSigDelegate callback);
        void ScenesName5(ScenesStringInputSigDelegate callback);
        void ScenesName6(ScenesStringInputSigDelegate callback);
        void ScenesName7(ScenesStringInputSigDelegate callback);
        void ActiveScene(ScenesStringInputSigDelegate callback);

    }

    public delegate void ScenesBoolInputSigDelegate(BoolInputSig boolInputSig, IScenes scenes);
    public delegate void ScenesStringInputSigDelegate(StringInputSig stringInputSig, IScenes scenes);

    internal class Scenes : IScenes, IDisposable
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
                public const uint Scenes0 = 1;
                public const uint Scenes1 = 2;
                public const uint Scenes2 = 3;
                public const uint Scenes3 = 4;
                public const uint Scenes4 = 5;
                public const uint Scenes5 = 6;
                public const uint Scenes6 = 7;
                public const uint Scenes7 = 8;
                public const uint Scenes8 = 9;
                public const uint Scenes9 = 10;
                public const uint Scenes10 = 11;
                public const uint Scenes11 = 12;
                public const uint Scenes12 = 13;
                public const uint Scenes13 = 14;
                public const uint Scenes14 = 15;
                public const uint Scenes15 = 16;
                public const uint Raise = 17;
                public const uint Lower = 18;

                public const uint Scenefb0 = 19;
                public const uint Scenefb1 = 20;
                public const uint Scenefb2 = 21;
                public const uint Scenefb3 = 22;
                public const uint Scenefb4 = 23;
                public const uint Scenefb5 = 24;
                public const uint Scenefb6 = 25;
                public const uint Scenefb7 = 26;
                public const uint Scenefb8 = 27;
                public const uint Scenefb9 = 28;
                public const uint Scenefb10 = 29;
                public const uint Scenefb11 = 30;
                public const uint Scenefb12 = 31;
                public const uint Scenefb13 = 32;
                public const uint Scenefb14 = 33;
                public const uint Scenefb15 = 34;
            }
            internal static class Strings
            {

                public const uint ScenesName0 = 1;
                public const uint ScenesName1 = 2;
                public const uint ScenesName2 = 3;
                public const uint ScenesName3 = 4;
                public const uint ScenesName4 = 5;
                public const uint ScenesName5 = 6;
                public const uint ScenesName6 = 7;
                public const uint ScenesName7 = 8;
                public const uint ActiveScene = 9;
            }
        }

        #endregion

        #region Construction and Initialization

        internal Scenes(ComponentMediator componentMediator, uint controlJoinId)
        {
            ComponentMediator = componentMediator;
            Initialize(controlJoinId);
        }

        private void Initialize(uint controlJoinId)
        {
            ControlJoinId = controlJoinId; 
 
            _devices = new List<BasicTriListWithSmartObject>(); 
 
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Scenes0, onScenes0);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Scenes1, onScenes1);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Scenes2, onScenes2);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Scenes3, onScenes3);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Scenes4, onScenes4);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Scenes5, onScenes5);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Scenes6, onScenes6);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Scenes7, onScenes7);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Scenes8, onScenes8);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Scenes9, onScenes9);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Scenes10, onScenes10);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Scenes11, onScenes11);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Scenes12, onScenes12);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Scenes13, onScenes13);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Scenes14, onScenes14);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Scenes15, onScenes15);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Raise, onRaise);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Lower, onLower);

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

        public event EventHandler<UIEventArgs> Scenes0;
        private void onScenes0(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Scenes0;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Scenes1;
        private void onScenes1(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Scenes1;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Scenes2;
        private void onScenes2(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Scenes2;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Scenes3;
        private void onScenes3(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Scenes3;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Scenes4;
        private void onScenes4(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Scenes4;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Scenes5;
        private void onScenes5(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Scenes5;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Scenes6;
        private void onScenes6(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Scenes6;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Scenes7;
        private void onScenes7(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Scenes7;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Scenes8;
        private void onScenes8(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Scenes8;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Scenes9;
        private void onScenes9(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Scenes9;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Scenes10;
        private void onScenes10(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Scenes10;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Scenes11;
        private void onScenes11(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Scenes11;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Scenes12;
        private void onScenes12(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Scenes12;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Scenes13;
        private void onScenes13(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Scenes13;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Scenes14;
        private void onScenes14(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Scenes14;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Scenes15;
        private void onScenes15(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Scenes15;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Raise;
        private void onRaise(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Raise;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Lower;
        private void onLower(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Lower;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }


        public void Scenefb0(ScenesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Scenefb0], this);
            }
        }

        public void Scenefb1(ScenesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Scenefb1], this);
            }
        }

        public void Scenefb2(ScenesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Scenefb2], this);
            }
        }

        public void Scenefb3(ScenesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Scenefb3], this);
            }
        }

        public void Scenefb4(ScenesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Scenefb4], this);
            }
        }

        public void Scenefb5(ScenesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Scenefb5], this);
            }
        }

        public void Scenefb6(ScenesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Scenefb6], this);
            }
        }

        public void Scenefb7(ScenesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Scenefb7], this);
            }
        }

        public void Scenefb8(ScenesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Scenefb8], this);
            }
        }

        public void Scenefb9(ScenesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Scenefb9], this);
            }
        }

        public void Scenefb10(ScenesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Scenefb10], this);
            }
        }

        public void Scenefb11(ScenesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Scenefb11], this);
            }
        }

        public void Scenefb12(ScenesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Scenefb12], this);
            }
        }

        public void Scenefb13(ScenesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Scenefb13], this);
            }
        }

        public void Scenefb14(ScenesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Scenefb14], this);
            }
        }

        public void Scenefb15(ScenesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Scenefb15], this);
            }
        }


        public void ScenesName0(ScenesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.ScenesName0], this);
            }
        }

        public void ScenesName1(ScenesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.ScenesName1], this);
            }
        }

        public void ScenesName2(ScenesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.ScenesName2], this);
            }
        }

        public void ScenesName3(ScenesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.ScenesName3], this);
            }
        }

        public void ScenesName4(ScenesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.ScenesName4], this);
            }
        }

        public void ScenesName5(ScenesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.ScenesName5], this);
            }
        }

        public void ScenesName6(ScenesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.ScenesName6], this);
            }
        }

        public void ScenesName7(ScenesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.ScenesName7], this);
            }
        }

        public void ActiveScene(ScenesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.ActiveScene], this);
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
            return string.Format("Contract: {0} Component: {1} HashCode: {2} {3}", "Scenes", GetType().Name, GetHashCode(), UserObject != null ? "UserObject: " + UserObject : null);
        }

        #endregion

        #region IDisposable

        public bool IsDisposed { get; set; }

        public void Dispose()
        {
            if (IsDisposed)
                return;

            IsDisposed = true;

            Scenes0 = null;
            Scenes1 = null;
            Scenes2 = null;
            Scenes3 = null;
            Scenes4 = null;
            Scenes5 = null;
            Scenes6 = null;
            Scenes7 = null;
            Scenes8 = null;
            Scenes9 = null;
            Scenes10 = null;
            Scenes11 = null;
            Scenes12 = null;
            Scenes13 = null;
            Scenes14 = null;
            Scenes15 = null;
            Raise = null;
            Lower = null;
        }

        #endregion

    }
}
