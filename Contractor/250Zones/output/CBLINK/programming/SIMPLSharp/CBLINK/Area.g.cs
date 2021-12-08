using System;
using System.Collections.Generic;
using System.Linq;
using Crestron.SimplSharpPro.DeviceSupport;
using Crestron.SimplSharpPro;

namespace CBLINK
{
    public interface IArea
    {
        object UserObject { get; set; }

        event EventHandler<UIEventArgs> AreaSelect0;
        event EventHandler<UIEventArgs> AreaSelect1;
        event EventHandler<UIEventArgs> AreaSelect2;
        event EventHandler<UIEventArgs> AreaSelect3;
        event EventHandler<UIEventArgs> AreaSelect4;
        event EventHandler<UIEventArgs> AreaSelect5;
        event EventHandler<UIEventArgs> AreaSelect6;
        event EventHandler<UIEventArgs> AreaSelect7;
        event EventHandler<UIEventArgs> AreaSelect8;
        event EventHandler<UIEventArgs> AreaSelect9;
        event EventHandler<UIEventArgs> AreaSelect10;
        event EventHandler<UIEventArgs> AreaSelect11;
        event EventHandler<UIEventArgs> AreaSelect12;
        event EventHandler<UIEventArgs> AreaSelect13;
        event EventHandler<UIEventArgs> AreaSelect14;
        event EventHandler<UIEventArgs> AreaSelect15;
        event EventHandler<UIEventArgs> AreaSelect16;
        event EventHandler<UIEventArgs> AreaSelect17;
        event EventHandler<UIEventArgs> AreaSelect18;
        event EventHandler<UIEventArgs> AreaSelect19;
        event EventHandler<UIEventArgs> AreaSelect20;
        event EventHandler<UIEventArgs> AreaSelect21;
        event EventHandler<UIEventArgs> AreaSelect22;
        event EventHandler<UIEventArgs> AreaSelect23;
        event EventHandler<UIEventArgs> AreaSelect24;
        event EventHandler<UIEventArgs> AreaSelect25;
        event EventHandler<UIEventArgs> AreaSelect26;
        event EventHandler<UIEventArgs> AreaSelect27;
        event EventHandler<UIEventArgs> AreaSelect28;
        event EventHandler<UIEventArgs> AreaSelect29;
        event EventHandler<UIEventArgs> AreaSelect30;
        event EventHandler<UIEventArgs> AreaSelect31;
        event EventHandler<UIEventArgs> AreaSelect32;
        event EventHandler<UIEventArgs> AreaSelect33;
        event EventHandler<UIEventArgs> AreaSelect34;
        event EventHandler<UIEventArgs> AreaSelect35;
        event EventHandler<UIEventArgs> AreaSelect36;
        event EventHandler<UIEventArgs> AreaSelect37;
        event EventHandler<UIEventArgs> AreaSelect38;
        event EventHandler<UIEventArgs> AreaSelect39;
        event EventHandler<UIEventArgs> AreaSelect40;
        event EventHandler<UIEventArgs> AreaSelect41;
        event EventHandler<UIEventArgs> AreaSelect42;
        event EventHandler<UIEventArgs> AreaSelect43;
        event EventHandler<UIEventArgs> AreaSelect44;
        event EventHandler<UIEventArgs> AreaSelect45;
        event EventHandler<UIEventArgs> AreaSelect46;
        event EventHandler<UIEventArgs> AreaSelect47;
        event EventHandler<UIEventArgs> AreaSelect48;
        event EventHandler<UIEventArgs> AreaSelect49;

        void AreaSelected0(AreaBoolInputSigDelegate callback);
        void AreaSelected1(AreaBoolInputSigDelegate callback);
        void AreaSelected2(AreaBoolInputSigDelegate callback);
        void AreaSelected3(AreaBoolInputSigDelegate callback);
        void AreaSelected4(AreaBoolInputSigDelegate callback);
        void AreaSelected5(AreaBoolInputSigDelegate callback);
        void AreaSelected6(AreaBoolInputSigDelegate callback);
        void AreaSelected7(AreaBoolInputSigDelegate callback);
        void AreaSelected8(AreaBoolInputSigDelegate callback);
        void AreaSelected9(AreaBoolInputSigDelegate callback);
        void AreaSelected10(AreaBoolInputSigDelegate callback);
        void AreaSelected11(AreaBoolInputSigDelegate callback);
        void AreaSelected12(AreaBoolInputSigDelegate callback);
        void AreaSelected13(AreaBoolInputSigDelegate callback);
        void AreaSelected14(AreaBoolInputSigDelegate callback);
        void AreaSelected15(AreaBoolInputSigDelegate callback);
        void AreaSelected16(AreaBoolInputSigDelegate callback);
        void AreaSelected17(AreaBoolInputSigDelegate callback);
        void AreaSelected18(AreaBoolInputSigDelegate callback);
        void AreaSelected19(AreaBoolInputSigDelegate callback);
        void AreaSelected20(AreaBoolInputSigDelegate callback);
        void AreaSelected21(AreaBoolInputSigDelegate callback);
        void AreaSelected22(AreaBoolInputSigDelegate callback);
        void AreaSelected23(AreaBoolInputSigDelegate callback);
        void AreaSelected24(AreaBoolInputSigDelegate callback);
        void AreaSelected25(AreaBoolInputSigDelegate callback);
        void AreaSelected26(AreaBoolInputSigDelegate callback);
        void AreaSelected27(AreaBoolInputSigDelegate callback);
        void AreaSelected28(AreaBoolInputSigDelegate callback);
        void AreaSelected29(AreaBoolInputSigDelegate callback);
        void AreaSelected30(AreaBoolInputSigDelegate callback);
        void AreaSelected31(AreaBoolInputSigDelegate callback);
        void AreaSelected32(AreaBoolInputSigDelegate callback);
        void AreaSelected33(AreaBoolInputSigDelegate callback);
        void AreaSelected34(AreaBoolInputSigDelegate callback);
        void AreaSelected35(AreaBoolInputSigDelegate callback);
        void AreaSelected36(AreaBoolInputSigDelegate callback);
        void AreaSelected37(AreaBoolInputSigDelegate callback);
        void AreaSelected38(AreaBoolInputSigDelegate callback);
        void AreaSelected39(AreaBoolInputSigDelegate callback);
        void AreaSelected40(AreaBoolInputSigDelegate callback);
        void AreaSelected41(AreaBoolInputSigDelegate callback);
        void AreaSelected42(AreaBoolInputSigDelegate callback);
        void AreaSelected43(AreaBoolInputSigDelegate callback);
        void AreaSelected44(AreaBoolInputSigDelegate callback);
        void AreaSelected45(AreaBoolInputSigDelegate callback);
        void AreaSelected46(AreaBoolInputSigDelegate callback);
        void AreaSelected47(AreaBoolInputSigDelegate callback);
        void AreaSelected48(AreaBoolInputSigDelegate callback);
        void AreaSelected49(AreaBoolInputSigDelegate callback);
        void Size(AreaUShortInputSigDelegate callback);
        void ActiveArea(AreaStringInputSigDelegate callback);
        void AreaName0(AreaStringInputSigDelegate callback);
        void AreaName1(AreaStringInputSigDelegate callback);
        void AreaName2(AreaStringInputSigDelegate callback);
        void AreaName3(AreaStringInputSigDelegate callback);
        void AreaName4(AreaStringInputSigDelegate callback);
        void AreaName5(AreaStringInputSigDelegate callback);
        void AreaName6(AreaStringInputSigDelegate callback);
        void AreaName7(AreaStringInputSigDelegate callback);
        void AreaName8(AreaStringInputSigDelegate callback);
        void AreaName9(AreaStringInputSigDelegate callback);
        void AreaName10(AreaStringInputSigDelegate callback);
        void AreaName11(AreaStringInputSigDelegate callback);
        void AreaName12(AreaStringInputSigDelegate callback);
        void AreaName13(AreaStringInputSigDelegate callback);
        void AreaName14(AreaStringInputSigDelegate callback);
        void AreaName15(AreaStringInputSigDelegate callback);
        void AreaName16(AreaStringInputSigDelegate callback);
        void AreaName17(AreaStringInputSigDelegate callback);
        void AreaName18(AreaStringInputSigDelegate callback);
        void AreaName19(AreaStringInputSigDelegate callback);
        void AreaName20(AreaStringInputSigDelegate callback);
        void AreaName21(AreaStringInputSigDelegate callback);
        void AreaName22(AreaStringInputSigDelegate callback);
        void AreaName23(AreaStringInputSigDelegate callback);
        void AreaName24(AreaStringInputSigDelegate callback);
        void AreaName25(AreaStringInputSigDelegate callback);
        void AreaName26(AreaStringInputSigDelegate callback);
        void AreaName27(AreaStringInputSigDelegate callback);
        void AreaName28(AreaStringInputSigDelegate callback);
        void AreaName29(AreaStringInputSigDelegate callback);
        void AreaName30(AreaStringInputSigDelegate callback);
        void AreaName31(AreaStringInputSigDelegate callback);
        void AreaName32(AreaStringInputSigDelegate callback);
        void AreaName33(AreaStringInputSigDelegate callback);
        void AreaName34(AreaStringInputSigDelegate callback);
        void AreaName35(AreaStringInputSigDelegate callback);
        void AreaName36(AreaStringInputSigDelegate callback);
        void AreaName37(AreaStringInputSigDelegate callback);
        void AreaName38(AreaStringInputSigDelegate callback);
        void AreaName39(AreaStringInputSigDelegate callback);
        void AreaName40(AreaStringInputSigDelegate callback);
        void AreaName41(AreaStringInputSigDelegate callback);
        void AreaName42(AreaStringInputSigDelegate callback);
        void AreaName43(AreaStringInputSigDelegate callback);
        void AreaName44(AreaStringInputSigDelegate callback);
        void AreaName45(AreaStringInputSigDelegate callback);
        void AreaName46(AreaStringInputSigDelegate callback);
        void AreaName47(AreaStringInputSigDelegate callback);
        void AreaName48(AreaStringInputSigDelegate callback);
        void AreaName49(AreaStringInputSigDelegate callback);

    }

    public delegate void AreaBoolInputSigDelegate(BoolInputSig boolInputSig, IArea area);
    public delegate void AreaUShortInputSigDelegate(UShortInputSig uShortInputSig, IArea area);
    public delegate void AreaStringInputSigDelegate(StringInputSig stringInputSig, IArea area);

    internal class Area : IArea, IDisposable
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
                public const uint AreaSelect0 = 1;
                public const uint AreaSelect1 = 2;
                public const uint AreaSelect2 = 3;
                public const uint AreaSelect3 = 4;
                public const uint AreaSelect4 = 5;
                public const uint AreaSelect5 = 6;
                public const uint AreaSelect6 = 7;
                public const uint AreaSelect7 = 8;
                public const uint AreaSelect8 = 9;
                public const uint AreaSelect9 = 10;
                public const uint AreaSelect10 = 11;
                public const uint AreaSelect11 = 12;
                public const uint AreaSelect12 = 13;
                public const uint AreaSelect13 = 14;
                public const uint AreaSelect14 = 15;
                public const uint AreaSelect15 = 16;
                public const uint AreaSelect16 = 17;
                public const uint AreaSelect17 = 18;
                public const uint AreaSelect18 = 19;
                public const uint AreaSelect19 = 20;
                public const uint AreaSelect20 = 21;
                public const uint AreaSelect21 = 22;
                public const uint AreaSelect22 = 23;
                public const uint AreaSelect23 = 24;
                public const uint AreaSelect24 = 25;
                public const uint AreaSelect25 = 26;
                public const uint AreaSelect26 = 27;
                public const uint AreaSelect27 = 28;
                public const uint AreaSelect28 = 29;
                public const uint AreaSelect29 = 30;
                public const uint AreaSelect30 = 31;
                public const uint AreaSelect31 = 32;
                public const uint AreaSelect32 = 33;
                public const uint AreaSelect33 = 34;
                public const uint AreaSelect34 = 35;
                public const uint AreaSelect35 = 36;
                public const uint AreaSelect36 = 37;
                public const uint AreaSelect37 = 38;
                public const uint AreaSelect38 = 39;
                public const uint AreaSelect39 = 40;
                public const uint AreaSelect40 = 41;
                public const uint AreaSelect41 = 42;
                public const uint AreaSelect42 = 43;
                public const uint AreaSelect43 = 44;
                public const uint AreaSelect44 = 45;
                public const uint AreaSelect45 = 46;
                public const uint AreaSelect46 = 47;
                public const uint AreaSelect47 = 48;
                public const uint AreaSelect48 = 49;
                public const uint AreaSelect49 = 50;

                public const uint AreaSelected0 = 1;
                public const uint AreaSelected1 = 2;
                public const uint AreaSelected2 = 3;
                public const uint AreaSelected3 = 4;
                public const uint AreaSelected4 = 5;
                public const uint AreaSelected5 = 6;
                public const uint AreaSelected6 = 7;
                public const uint AreaSelected7 = 8;
                public const uint AreaSelected8 = 9;
                public const uint AreaSelected9 = 10;
                public const uint AreaSelected10 = 11;
                public const uint AreaSelected11 = 12;
                public const uint AreaSelected12 = 13;
                public const uint AreaSelected13 = 14;
                public const uint AreaSelected14 = 15;
                public const uint AreaSelected15 = 16;
                public const uint AreaSelected16 = 17;
                public const uint AreaSelected17 = 18;
                public const uint AreaSelected18 = 19;
                public const uint AreaSelected19 = 20;
                public const uint AreaSelected20 = 21;
                public const uint AreaSelected21 = 22;
                public const uint AreaSelected22 = 23;
                public const uint AreaSelected23 = 24;
                public const uint AreaSelected24 = 25;
                public const uint AreaSelected25 = 26;
                public const uint AreaSelected26 = 27;
                public const uint AreaSelected27 = 28;
                public const uint AreaSelected28 = 29;
                public const uint AreaSelected29 = 30;
                public const uint AreaSelected30 = 31;
                public const uint AreaSelected31 = 32;
                public const uint AreaSelected32 = 33;
                public const uint AreaSelected33 = 34;
                public const uint AreaSelected34 = 35;
                public const uint AreaSelected35 = 36;
                public const uint AreaSelected36 = 37;
                public const uint AreaSelected37 = 38;
                public const uint AreaSelected38 = 39;
                public const uint AreaSelected39 = 40;
                public const uint AreaSelected40 = 41;
                public const uint AreaSelected41 = 42;
                public const uint AreaSelected42 = 43;
                public const uint AreaSelected43 = 44;
                public const uint AreaSelected44 = 45;
                public const uint AreaSelected45 = 46;
                public const uint AreaSelected46 = 47;
                public const uint AreaSelected47 = 48;
                public const uint AreaSelected48 = 49;
                public const uint AreaSelected49 = 50;
            }
            internal static class Numerics
            {

                public const uint Size = 1;
            }
            internal static class Strings
            {

                public const uint ActiveArea = 1;
                public const uint AreaName0 = 2;
                public const uint AreaName1 = 3;
                public const uint AreaName2 = 4;
                public const uint AreaName3 = 5;
                public const uint AreaName4 = 6;
                public const uint AreaName5 = 7;
                public const uint AreaName6 = 8;
                public const uint AreaName7 = 9;
                public const uint AreaName8 = 10;
                public const uint AreaName9 = 11;
                public const uint AreaName10 = 12;
                public const uint AreaName11 = 13;
                public const uint AreaName12 = 14;
                public const uint AreaName13 = 15;
                public const uint AreaName14 = 16;
                public const uint AreaName15 = 17;
                public const uint AreaName16 = 18;
                public const uint AreaName17 = 19;
                public const uint AreaName18 = 20;
                public const uint AreaName19 = 21;
                public const uint AreaName20 = 22;
                public const uint AreaName21 = 23;
                public const uint AreaName22 = 24;
                public const uint AreaName23 = 25;
                public const uint AreaName24 = 26;
                public const uint AreaName25 = 27;
                public const uint AreaName26 = 28;
                public const uint AreaName27 = 29;
                public const uint AreaName28 = 30;
                public const uint AreaName29 = 31;
                public const uint AreaName30 = 32;
                public const uint AreaName31 = 33;
                public const uint AreaName32 = 34;
                public const uint AreaName33 = 35;
                public const uint AreaName34 = 36;
                public const uint AreaName35 = 37;
                public const uint AreaName36 = 38;
                public const uint AreaName37 = 39;
                public const uint AreaName38 = 40;
                public const uint AreaName39 = 41;
                public const uint AreaName40 = 42;
                public const uint AreaName41 = 43;
                public const uint AreaName42 = 44;
                public const uint AreaName43 = 45;
                public const uint AreaName44 = 46;
                public const uint AreaName45 = 47;
                public const uint AreaName46 = 48;
                public const uint AreaName47 = 49;
                public const uint AreaName48 = 50;
                public const uint AreaName49 = 51;
            }
        }

        #endregion

        #region Construction and Initialization

        internal Area(ComponentMediator componentMediator, uint controlJoinId)
        {
            ComponentMediator = componentMediator;
            Initialize(controlJoinId);
        }

        private void Initialize(uint controlJoinId)
        {
            ControlJoinId = controlJoinId; 
 
            _devices = new List<BasicTriListWithSmartObject>(); 
 
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.AreaSelect0, onAreaSelect0);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.AreaSelect1, onAreaSelect1);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.AreaSelect2, onAreaSelect2);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.AreaSelect3, onAreaSelect3);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.AreaSelect4, onAreaSelect4);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.AreaSelect5, onAreaSelect5);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.AreaSelect6, onAreaSelect6);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.AreaSelect7, onAreaSelect7);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.AreaSelect8, onAreaSelect8);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.AreaSelect9, onAreaSelect9);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.AreaSelect10, onAreaSelect10);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.AreaSelect11, onAreaSelect11);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.AreaSelect12, onAreaSelect12);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.AreaSelect13, onAreaSelect13);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.AreaSelect14, onAreaSelect14);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.AreaSelect15, onAreaSelect15);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.AreaSelect16, onAreaSelect16);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.AreaSelect17, onAreaSelect17);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.AreaSelect18, onAreaSelect18);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.AreaSelect19, onAreaSelect19);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.AreaSelect20, onAreaSelect20);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.AreaSelect21, onAreaSelect21);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.AreaSelect22, onAreaSelect22);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.AreaSelect23, onAreaSelect23);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.AreaSelect24, onAreaSelect24);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.AreaSelect25, onAreaSelect25);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.AreaSelect26, onAreaSelect26);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.AreaSelect27, onAreaSelect27);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.AreaSelect28, onAreaSelect28);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.AreaSelect29, onAreaSelect29);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.AreaSelect30, onAreaSelect30);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.AreaSelect31, onAreaSelect31);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.AreaSelect32, onAreaSelect32);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.AreaSelect33, onAreaSelect33);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.AreaSelect34, onAreaSelect34);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.AreaSelect35, onAreaSelect35);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.AreaSelect36, onAreaSelect36);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.AreaSelect37, onAreaSelect37);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.AreaSelect38, onAreaSelect38);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.AreaSelect39, onAreaSelect39);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.AreaSelect40, onAreaSelect40);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.AreaSelect41, onAreaSelect41);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.AreaSelect42, onAreaSelect42);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.AreaSelect43, onAreaSelect43);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.AreaSelect44, onAreaSelect44);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.AreaSelect45, onAreaSelect45);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.AreaSelect46, onAreaSelect46);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.AreaSelect47, onAreaSelect47);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.AreaSelect48, onAreaSelect48);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.AreaSelect49, onAreaSelect49);

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

        public event EventHandler<UIEventArgs> AreaSelect0;
        private void onAreaSelect0(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = AreaSelect0;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> AreaSelect1;
        private void onAreaSelect1(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = AreaSelect1;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> AreaSelect2;
        private void onAreaSelect2(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = AreaSelect2;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> AreaSelect3;
        private void onAreaSelect3(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = AreaSelect3;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> AreaSelect4;
        private void onAreaSelect4(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = AreaSelect4;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> AreaSelect5;
        private void onAreaSelect5(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = AreaSelect5;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> AreaSelect6;
        private void onAreaSelect6(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = AreaSelect6;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> AreaSelect7;
        private void onAreaSelect7(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = AreaSelect7;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> AreaSelect8;
        private void onAreaSelect8(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = AreaSelect8;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> AreaSelect9;
        private void onAreaSelect9(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = AreaSelect9;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> AreaSelect10;
        private void onAreaSelect10(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = AreaSelect10;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> AreaSelect11;
        private void onAreaSelect11(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = AreaSelect11;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> AreaSelect12;
        private void onAreaSelect12(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = AreaSelect12;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> AreaSelect13;
        private void onAreaSelect13(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = AreaSelect13;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> AreaSelect14;
        private void onAreaSelect14(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = AreaSelect14;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> AreaSelect15;
        private void onAreaSelect15(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = AreaSelect15;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> AreaSelect16;
        private void onAreaSelect16(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = AreaSelect16;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> AreaSelect17;
        private void onAreaSelect17(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = AreaSelect17;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> AreaSelect18;
        private void onAreaSelect18(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = AreaSelect18;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> AreaSelect19;
        private void onAreaSelect19(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = AreaSelect19;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> AreaSelect20;
        private void onAreaSelect20(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = AreaSelect20;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> AreaSelect21;
        private void onAreaSelect21(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = AreaSelect21;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> AreaSelect22;
        private void onAreaSelect22(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = AreaSelect22;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> AreaSelect23;
        private void onAreaSelect23(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = AreaSelect23;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> AreaSelect24;
        private void onAreaSelect24(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = AreaSelect24;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> AreaSelect25;
        private void onAreaSelect25(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = AreaSelect25;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> AreaSelect26;
        private void onAreaSelect26(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = AreaSelect26;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> AreaSelect27;
        private void onAreaSelect27(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = AreaSelect27;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> AreaSelect28;
        private void onAreaSelect28(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = AreaSelect28;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> AreaSelect29;
        private void onAreaSelect29(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = AreaSelect29;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> AreaSelect30;
        private void onAreaSelect30(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = AreaSelect30;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> AreaSelect31;
        private void onAreaSelect31(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = AreaSelect31;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> AreaSelect32;
        private void onAreaSelect32(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = AreaSelect32;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> AreaSelect33;
        private void onAreaSelect33(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = AreaSelect33;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> AreaSelect34;
        private void onAreaSelect34(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = AreaSelect34;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> AreaSelect35;
        private void onAreaSelect35(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = AreaSelect35;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> AreaSelect36;
        private void onAreaSelect36(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = AreaSelect36;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> AreaSelect37;
        private void onAreaSelect37(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = AreaSelect37;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> AreaSelect38;
        private void onAreaSelect38(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = AreaSelect38;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> AreaSelect39;
        private void onAreaSelect39(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = AreaSelect39;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> AreaSelect40;
        private void onAreaSelect40(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = AreaSelect40;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> AreaSelect41;
        private void onAreaSelect41(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = AreaSelect41;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> AreaSelect42;
        private void onAreaSelect42(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = AreaSelect42;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> AreaSelect43;
        private void onAreaSelect43(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = AreaSelect43;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> AreaSelect44;
        private void onAreaSelect44(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = AreaSelect44;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> AreaSelect45;
        private void onAreaSelect45(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = AreaSelect45;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> AreaSelect46;
        private void onAreaSelect46(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = AreaSelect46;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> AreaSelect47;
        private void onAreaSelect47(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = AreaSelect47;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> AreaSelect48;
        private void onAreaSelect48(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = AreaSelect48;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> AreaSelect49;
        private void onAreaSelect49(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = AreaSelect49;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }


        public void AreaSelected0(AreaBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.AreaSelected0], this);
            }
        }

        public void AreaSelected1(AreaBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.AreaSelected1], this);
            }
        }

        public void AreaSelected2(AreaBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.AreaSelected2], this);
            }
        }

        public void AreaSelected3(AreaBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.AreaSelected3], this);
            }
        }

        public void AreaSelected4(AreaBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.AreaSelected4], this);
            }
        }

        public void AreaSelected5(AreaBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.AreaSelected5], this);
            }
        }

        public void AreaSelected6(AreaBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.AreaSelected6], this);
            }
        }

        public void AreaSelected7(AreaBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.AreaSelected7], this);
            }
        }

        public void AreaSelected8(AreaBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.AreaSelected8], this);
            }
        }

        public void AreaSelected9(AreaBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.AreaSelected9], this);
            }
        }

        public void AreaSelected10(AreaBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.AreaSelected10], this);
            }
        }

        public void AreaSelected11(AreaBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.AreaSelected11], this);
            }
        }

        public void AreaSelected12(AreaBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.AreaSelected12], this);
            }
        }

        public void AreaSelected13(AreaBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.AreaSelected13], this);
            }
        }

        public void AreaSelected14(AreaBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.AreaSelected14], this);
            }
        }

        public void AreaSelected15(AreaBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.AreaSelected15], this);
            }
        }

        public void AreaSelected16(AreaBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.AreaSelected16], this);
            }
        }

        public void AreaSelected17(AreaBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.AreaSelected17], this);
            }
        }

        public void AreaSelected18(AreaBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.AreaSelected18], this);
            }
        }

        public void AreaSelected19(AreaBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.AreaSelected19], this);
            }
        }

        public void AreaSelected20(AreaBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.AreaSelected20], this);
            }
        }

        public void AreaSelected21(AreaBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.AreaSelected21], this);
            }
        }

        public void AreaSelected22(AreaBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.AreaSelected22], this);
            }
        }

        public void AreaSelected23(AreaBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.AreaSelected23], this);
            }
        }

        public void AreaSelected24(AreaBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.AreaSelected24], this);
            }
        }

        public void AreaSelected25(AreaBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.AreaSelected25], this);
            }
        }

        public void AreaSelected26(AreaBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.AreaSelected26], this);
            }
        }

        public void AreaSelected27(AreaBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.AreaSelected27], this);
            }
        }

        public void AreaSelected28(AreaBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.AreaSelected28], this);
            }
        }

        public void AreaSelected29(AreaBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.AreaSelected29], this);
            }
        }

        public void AreaSelected30(AreaBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.AreaSelected30], this);
            }
        }

        public void AreaSelected31(AreaBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.AreaSelected31], this);
            }
        }

        public void AreaSelected32(AreaBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.AreaSelected32], this);
            }
        }

        public void AreaSelected33(AreaBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.AreaSelected33], this);
            }
        }

        public void AreaSelected34(AreaBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.AreaSelected34], this);
            }
        }

        public void AreaSelected35(AreaBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.AreaSelected35], this);
            }
        }

        public void AreaSelected36(AreaBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.AreaSelected36], this);
            }
        }

        public void AreaSelected37(AreaBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.AreaSelected37], this);
            }
        }

        public void AreaSelected38(AreaBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.AreaSelected38], this);
            }
        }

        public void AreaSelected39(AreaBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.AreaSelected39], this);
            }
        }

        public void AreaSelected40(AreaBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.AreaSelected40], this);
            }
        }

        public void AreaSelected41(AreaBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.AreaSelected41], this);
            }
        }

        public void AreaSelected42(AreaBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.AreaSelected42], this);
            }
        }

        public void AreaSelected43(AreaBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.AreaSelected43], this);
            }
        }

        public void AreaSelected44(AreaBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.AreaSelected44], this);
            }
        }

        public void AreaSelected45(AreaBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.AreaSelected45], this);
            }
        }

        public void AreaSelected46(AreaBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.AreaSelected46], this);
            }
        }

        public void AreaSelected47(AreaBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.AreaSelected47], this);
            }
        }

        public void AreaSelected48(AreaBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.AreaSelected48], this);
            }
        }

        public void AreaSelected49(AreaBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.AreaSelected49], this);
            }
        }


        public void Size(AreaUShortInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].UShortInput[Joins.Numerics.Size], this);
            }
        }


        public void ActiveArea(AreaStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.ActiveArea], this);
            }
        }

        public void AreaName0(AreaStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.AreaName0], this);
            }
        }

        public void AreaName1(AreaStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.AreaName1], this);
            }
        }

        public void AreaName2(AreaStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.AreaName2], this);
            }
        }

        public void AreaName3(AreaStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.AreaName3], this);
            }
        }

        public void AreaName4(AreaStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.AreaName4], this);
            }
        }

        public void AreaName5(AreaStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.AreaName5], this);
            }
        }

        public void AreaName6(AreaStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.AreaName6], this);
            }
        }

        public void AreaName7(AreaStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.AreaName7], this);
            }
        }

        public void AreaName8(AreaStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.AreaName8], this);
            }
        }

        public void AreaName9(AreaStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.AreaName9], this);
            }
        }

        public void AreaName10(AreaStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.AreaName10], this);
            }
        }

        public void AreaName11(AreaStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.AreaName11], this);
            }
        }

        public void AreaName12(AreaStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.AreaName12], this);
            }
        }

        public void AreaName13(AreaStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.AreaName13], this);
            }
        }

        public void AreaName14(AreaStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.AreaName14], this);
            }
        }

        public void AreaName15(AreaStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.AreaName15], this);
            }
        }

        public void AreaName16(AreaStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.AreaName16], this);
            }
        }

        public void AreaName17(AreaStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.AreaName17], this);
            }
        }

        public void AreaName18(AreaStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.AreaName18], this);
            }
        }

        public void AreaName19(AreaStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.AreaName19], this);
            }
        }

        public void AreaName20(AreaStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.AreaName20], this);
            }
        }

        public void AreaName21(AreaStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.AreaName21], this);
            }
        }

        public void AreaName22(AreaStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.AreaName22], this);
            }
        }

        public void AreaName23(AreaStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.AreaName23], this);
            }
        }

        public void AreaName24(AreaStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.AreaName24], this);
            }
        }

        public void AreaName25(AreaStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.AreaName25], this);
            }
        }

        public void AreaName26(AreaStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.AreaName26], this);
            }
        }

        public void AreaName27(AreaStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.AreaName27], this);
            }
        }

        public void AreaName28(AreaStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.AreaName28], this);
            }
        }

        public void AreaName29(AreaStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.AreaName29], this);
            }
        }

        public void AreaName30(AreaStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.AreaName30], this);
            }
        }

        public void AreaName31(AreaStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.AreaName31], this);
            }
        }

        public void AreaName32(AreaStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.AreaName32], this);
            }
        }

        public void AreaName33(AreaStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.AreaName33], this);
            }
        }

        public void AreaName34(AreaStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.AreaName34], this);
            }
        }

        public void AreaName35(AreaStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.AreaName35], this);
            }
        }

        public void AreaName36(AreaStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.AreaName36], this);
            }
        }

        public void AreaName37(AreaStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.AreaName37], this);
            }
        }

        public void AreaName38(AreaStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.AreaName38], this);
            }
        }

        public void AreaName39(AreaStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.AreaName39], this);
            }
        }

        public void AreaName40(AreaStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.AreaName40], this);
            }
        }

        public void AreaName41(AreaStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.AreaName41], this);
            }
        }

        public void AreaName42(AreaStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.AreaName42], this);
            }
        }

        public void AreaName43(AreaStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.AreaName43], this);
            }
        }

        public void AreaName44(AreaStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.AreaName44], this);
            }
        }

        public void AreaName45(AreaStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.AreaName45], this);
            }
        }

        public void AreaName46(AreaStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.AreaName46], this);
            }
        }

        public void AreaName47(AreaStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.AreaName47], this);
            }
        }

        public void AreaName48(AreaStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.AreaName48], this);
            }
        }

        public void AreaName49(AreaStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.AreaName49], this);
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
            return string.Format("Contract: {0} Component: {1} HashCode: {2} {3}", "Area", GetType().Name, GetHashCode(), UserObject != null ? "UserObject: " + UserObject : null);
        }

        #endregion

        #region IDisposable

        public bool IsDisposed { get; set; }

        public void Dispose()
        {
            if (IsDisposed)
                return;

            IsDisposed = true;

            AreaSelect0 = null;
            AreaSelect1 = null;
            AreaSelect2 = null;
            AreaSelect3 = null;
            AreaSelect4 = null;
            AreaSelect5 = null;
            AreaSelect6 = null;
            AreaSelect7 = null;
            AreaSelect8 = null;
            AreaSelect9 = null;
            AreaSelect10 = null;
            AreaSelect11 = null;
            AreaSelect12 = null;
            AreaSelect13 = null;
            AreaSelect14 = null;
            AreaSelect15 = null;
            AreaSelect16 = null;
            AreaSelect17 = null;
            AreaSelect18 = null;
            AreaSelect19 = null;
            AreaSelect20 = null;
            AreaSelect21 = null;
            AreaSelect22 = null;
            AreaSelect23 = null;
            AreaSelect24 = null;
            AreaSelect25 = null;
            AreaSelect26 = null;
            AreaSelect27 = null;
            AreaSelect28 = null;
            AreaSelect29 = null;
            AreaSelect30 = null;
            AreaSelect31 = null;
            AreaSelect32 = null;
            AreaSelect33 = null;
            AreaSelect34 = null;
            AreaSelect35 = null;
            AreaSelect36 = null;
            AreaSelect37 = null;
            AreaSelect38 = null;
            AreaSelect39 = null;
            AreaSelect40 = null;
            AreaSelect41 = null;
            AreaSelect42 = null;
            AreaSelect43 = null;
            AreaSelect44 = null;
            AreaSelect45 = null;
            AreaSelect46 = null;
            AreaSelect47 = null;
            AreaSelect48 = null;
            AreaSelect49 = null;
        }

        #endregion

    }
}
