using System;
using System.Collections.Generic;
using System.Linq;
using Crestron.SimplSharpPro.DeviceSupport;
using Crestron.SimplSharpPro;

namespace CBLINK
{
    public interface ISch
    {
        object UserObject { get; set; }

        event EventHandler<UIEventArgs> ET0;
        event EventHandler<UIEventArgs> ET1;
        event EventHandler<UIEventArgs> ET2;
        event EventHandler<UIEventArgs> ET3;
        event EventHandler<UIEventArgs> ET4;
        event EventHandler<UIEventArgs> ET5;
        event EventHandler<UIEventArgs> ET6;
        event EventHandler<UIEventArgs> ET7;
        event EventHandler<UIEventArgs> ET8;
        event EventHandler<UIEventArgs> ET9;
        event EventHandler<UIEventArgs> ET10;
        event EventHandler<UIEventArgs> Mo0;
        event EventHandler<UIEventArgs> Tu0;
        event EventHandler<UIEventArgs> We0;
        event EventHandler<UIEventArgs> Th0;
        event EventHandler<UIEventArgs> Fr0;
        event EventHandler<UIEventArgs> Sa0;
        event EventHandler<UIEventArgs> Su0;
        event EventHandler<UIEventArgs> Mo1;
        event EventHandler<UIEventArgs> Tu1;
        event EventHandler<UIEventArgs> We1;
        event EventHandler<UIEventArgs> Th1;
        event EventHandler<UIEventArgs> Fr1;
        event EventHandler<UIEventArgs> Sa1;
        event EventHandler<UIEventArgs> Su1;
        event EventHandler<UIEventArgs> Mo2;
        event EventHandler<UIEventArgs> Tu2;
        event EventHandler<UIEventArgs> We2;
        event EventHandler<UIEventArgs> Th2;
        event EventHandler<UIEventArgs> Fr2;
        event EventHandler<UIEventArgs> Sa2;
        event EventHandler<UIEventArgs> Su2;
        event EventHandler<UIEventArgs> Mo3;
        event EventHandler<UIEventArgs> Tu3;
        event EventHandler<UIEventArgs> We3;
        event EventHandler<UIEventArgs> Th3;
        event EventHandler<UIEventArgs> Fr3;
        event EventHandler<UIEventArgs> Sa3;
        event EventHandler<UIEventArgs> Su3;
        event EventHandler<UIEventArgs> Mo4;
        event EventHandler<UIEventArgs> Tu4;
        event EventHandler<UIEventArgs> We4;
        event EventHandler<UIEventArgs> Th4;
        event EventHandler<UIEventArgs> Fr4;
        event EventHandler<UIEventArgs> Sa4;
        event EventHandler<UIEventArgs> Su4;
        event EventHandler<UIEventArgs> Mo5;
        event EventHandler<UIEventArgs> Tu5;
        event EventHandler<UIEventArgs> We5;
        event EventHandler<UIEventArgs> Th5;
        event EventHandler<UIEventArgs> Fr5;
        event EventHandler<UIEventArgs> Sa5;
        event EventHandler<UIEventArgs> Su5;
        event EventHandler<UIEventArgs> Mo6;
        event EventHandler<UIEventArgs> Tu6;
        event EventHandler<UIEventArgs> We6;
        event EventHandler<UIEventArgs> Th6;
        event EventHandler<UIEventArgs> Fr6;
        event EventHandler<UIEventArgs> Sa6;
        event EventHandler<UIEventArgs> Su6;

        void ETF0(SchBoolInputSigDelegate callback);
        void ETF1(SchBoolInputSigDelegate callback);
        void ETF2(SchBoolInputSigDelegate callback);
        void ETF3(SchBoolInputSigDelegate callback);
        void ETF4(SchBoolInputSigDelegate callback);
        void ETF5(SchBoolInputSigDelegate callback);
        void ETF6(SchBoolInputSigDelegate callback);
        void ETF7(SchBoolInputSigDelegate callback);
        void ETF8(SchBoolInputSigDelegate callback);
        void ETF9(SchBoolInputSigDelegate callback);
        void ETF10(SchBoolInputSigDelegate callback);
        void fbMo0(SchBoolInputSigDelegate callback);
        void fbTu0(SchBoolInputSigDelegate callback);
        void fbWe0(SchBoolInputSigDelegate callback);
        void fbTh0(SchBoolInputSigDelegate callback);
        void fbFr0(SchBoolInputSigDelegate callback);
        void fbSa0(SchBoolInputSigDelegate callback);
        void fbSu0(SchBoolInputSigDelegate callback);
        void fbMo1(SchBoolInputSigDelegate callback);
        void fbTu1(SchBoolInputSigDelegate callback);
        void fbWe1(SchBoolInputSigDelegate callback);
        void fbTh1(SchBoolInputSigDelegate callback);
        void fbFr1(SchBoolInputSigDelegate callback);
        void fbSa1(SchBoolInputSigDelegate callback);
        void fbSu1(SchBoolInputSigDelegate callback);
        void fbMo2(SchBoolInputSigDelegate callback);
        void fbTu2(SchBoolInputSigDelegate callback);
        void fbWe2(SchBoolInputSigDelegate callback);
        void fbTh2(SchBoolInputSigDelegate callback);
        void fbFr2(SchBoolInputSigDelegate callback);
        void fbSa2(SchBoolInputSigDelegate callback);
        void fbSu2(SchBoolInputSigDelegate callback);
        void fbMo3(SchBoolInputSigDelegate callback);
        void fbTu3(SchBoolInputSigDelegate callback);
        void fbWe3(SchBoolInputSigDelegate callback);
        void fbTh3(SchBoolInputSigDelegate callback);
        void fbFr3(SchBoolInputSigDelegate callback);
        void fbSa3(SchBoolInputSigDelegate callback);
        void fbSu3(SchBoolInputSigDelegate callback);
        void fbMo4(SchBoolInputSigDelegate callback);
        void fbTu4(SchBoolInputSigDelegate callback);
        void fbWe4(SchBoolInputSigDelegate callback);
        void fbTh4(SchBoolInputSigDelegate callback);
        void fbFr4(SchBoolInputSigDelegate callback);
        void fbSa4(SchBoolInputSigDelegate callback);
        void fbSu4(SchBoolInputSigDelegate callback);
        void fbMo5(SchBoolInputSigDelegate callback);
        void fbTu5(SchBoolInputSigDelegate callback);
        void fbWe5(SchBoolInputSigDelegate callback);
        void fbTh5(SchBoolInputSigDelegate callback);
        void fbFr5(SchBoolInputSigDelegate callback);
        void fbSa5(SchBoolInputSigDelegate callback);
        void fbSu5(SchBoolInputSigDelegate callback);
        void fbMo6(SchBoolInputSigDelegate callback);
        void fbTu6(SchBoolInputSigDelegate callback);
        void fbWe6(SchBoolInputSigDelegate callback);
        void fbTh6(SchBoolInputSigDelegate callback);
        void fbFr6(SchBoolInputSigDelegate callback);
        void fbSa6(SchBoolInputSigDelegate callback);
        void fbSu6(SchBoolInputSigDelegate callback);
        void EN0(SchStringInputSigDelegate callback);
        void EN1(SchStringInputSigDelegate callback);
        void EN2(SchStringInputSigDelegate callback);
        void EN3(SchStringInputSigDelegate callback);
        void EN4(SchStringInputSigDelegate callback);
        void EN5(SchStringInputSigDelegate callback);
        void EN6(SchStringInputSigDelegate callback);
        void EN7(SchStringInputSigDelegate callback);
        void EN8(SchStringInputSigDelegate callback);
        void EN9(SchStringInputSigDelegate callback);
        void EN10(SchStringInputSigDelegate callback);

    }

    public delegate void SchBoolInputSigDelegate(BoolInputSig boolInputSig, ISch sch);
    public delegate void SchStringInputSigDelegate(StringInputSig stringInputSig, ISch sch);

    internal class Sch : ISch, IDisposable
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
                public const uint ET0 = 1;
                public const uint ET1 = 2;
                public const uint ET2 = 3;
                public const uint ET3 = 4;
                public const uint ET4 = 5;
                public const uint ET5 = 6;
                public const uint ET6 = 7;
                public const uint ET7 = 8;
                public const uint ET8 = 9;
                public const uint ET9 = 10;
                public const uint ET10 = 11;
                public const uint Mo0 = 12;
                public const uint Tu0 = 13;
                public const uint We0 = 14;
                public const uint Th0 = 15;
                public const uint Fr0 = 16;
                public const uint Sa0 = 17;
                public const uint Su0 = 18;
                public const uint Mo1 = 19;
                public const uint Tu1 = 20;
                public const uint We1 = 21;
                public const uint Th1 = 22;
                public const uint Fr1 = 23;
                public const uint Sa1 = 24;
                public const uint Su1 = 25;
                public const uint Mo2 = 26;
                public const uint Tu2 = 27;
                public const uint We2 = 28;
                public const uint Th2 = 29;
                public const uint Fr2 = 30;
                public const uint Sa2 = 31;
                public const uint Su2 = 32;
                public const uint Mo3 = 33;
                public const uint Tu3 = 34;
                public const uint We3 = 35;
                public const uint Th3 = 36;
                public const uint Fr3 = 37;
                public const uint Sa3 = 38;
                public const uint Su3 = 39;
                public const uint Mo4 = 40;
                public const uint Tu4 = 41;
                public const uint We4 = 42;
                public const uint Th4 = 43;
                public const uint Fr4 = 44;
                public const uint Sa4 = 45;
                public const uint Su4 = 46;
                public const uint Mo5 = 47;
                public const uint Tu5 = 48;
                public const uint We5 = 49;
                public const uint Th5 = 50;
                public const uint Fr5 = 51;
                public const uint Sa5 = 52;
                public const uint Su5 = 53;
                public const uint Mo6 = 54;
                public const uint Tu6 = 55;
                public const uint We6 = 56;
                public const uint Th6 = 57;
                public const uint Fr6 = 58;
                public const uint Sa6 = 59;
                public const uint Su6 = 60;

                public const uint ETF0 = 1;
                public const uint ETF1 = 2;
                public const uint ETF2 = 3;
                public const uint ETF3 = 4;
                public const uint ETF4 = 5;
                public const uint ETF5 = 6;
                public const uint ETF6 = 7;
                public const uint ETF7 = 8;
                public const uint ETF8 = 9;
                public const uint ETF9 = 10;
                public const uint ETF10 = 11;
                public const uint fbMo0 = 12;
                public const uint fbTu0 = 13;
                public const uint fbWe0 = 14;
                public const uint fbTh0 = 15;
                public const uint fbFr0 = 16;
                public const uint fbSa0 = 17;
                public const uint fbSu0 = 18;
                public const uint fbMo1 = 19;
                public const uint fbTu1 = 20;
                public const uint fbWe1 = 21;
                public const uint fbTh1 = 22;
                public const uint fbFr1 = 23;
                public const uint fbSa1 = 24;
                public const uint fbSu1 = 25;
                public const uint fbMo2 = 26;
                public const uint fbTu2 = 27;
                public const uint fbWe2 = 28;
                public const uint fbTh2 = 29;
                public const uint fbFr2 = 30;
                public const uint fbSa2 = 31;
                public const uint fbSu2 = 32;
                public const uint fbMo3 = 33;
                public const uint fbTu3 = 34;
                public const uint fbWe3 = 35;
                public const uint fbTh3 = 36;
                public const uint fbFr3 = 37;
                public const uint fbSa3 = 38;
                public const uint fbSu3 = 39;
                public const uint fbMo4 = 40;
                public const uint fbTu4 = 41;
                public const uint fbWe4 = 42;
                public const uint fbTh4 = 43;
                public const uint fbFr4 = 44;
                public const uint fbSa4 = 45;
                public const uint fbSu4 = 46;
                public const uint fbMo5 = 47;
                public const uint fbTu5 = 48;
                public const uint fbWe5 = 49;
                public const uint fbTh5 = 50;
                public const uint fbFr5 = 51;
                public const uint fbSa5 = 52;
                public const uint fbSu5 = 53;
                public const uint fbMo6 = 54;
                public const uint fbTu6 = 55;
                public const uint fbWe6 = 56;
                public const uint fbTh6 = 57;
                public const uint fbFr6 = 58;
                public const uint fbSa6 = 59;
                public const uint fbSu6 = 60;
            }
            internal static class Strings
            {

                public const uint EN0 = 1;
                public const uint EN1 = 2;
                public const uint EN2 = 3;
                public const uint EN3 = 4;
                public const uint EN4 = 5;
                public const uint EN5 = 6;
                public const uint EN6 = 7;
                public const uint EN7 = 8;
                public const uint EN8 = 9;
                public const uint EN9 = 10;
                public const uint EN10 = 11;
            }
        }

        #endregion

        #region Construction and Initialization

        internal Sch(ComponentMediator componentMediator, uint controlJoinId)
        {
            ComponentMediator = componentMediator;
            Initialize(controlJoinId);
        }

        private void Initialize(uint controlJoinId)
        {
            ControlJoinId = controlJoinId; 
 
            _devices = new List<BasicTriListWithSmartObject>(); 
 
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.ET0, onET0);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.ET1, onET1);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.ET2, onET2);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.ET3, onET3);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.ET4, onET4);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.ET5, onET5);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.ET6, onET6);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.ET7, onET7);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.ET8, onET8);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.ET9, onET9);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.ET10, onET10);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Mo0, onMo0);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Tu0, onTu0);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.We0, onWe0);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Th0, onTh0);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Fr0, onFr0);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Sa0, onSa0);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Su0, onSu0);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Mo1, onMo1);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Tu1, onTu1);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.We1, onWe1);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Th1, onTh1);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Fr1, onFr1);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Sa1, onSa1);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Su1, onSu1);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Mo2, onMo2);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Tu2, onTu2);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.We2, onWe2);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Th2, onTh2);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Fr2, onFr2);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Sa2, onSa2);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Su2, onSu2);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Mo3, onMo3);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Tu3, onTu3);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.We3, onWe3);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Th3, onTh3);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Fr3, onFr3);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Sa3, onSa3);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Su3, onSu3);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Mo4, onMo4);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Tu4, onTu4);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.We4, onWe4);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Th4, onTh4);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Fr4, onFr4);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Sa4, onSa4);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Su4, onSu4);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Mo5, onMo5);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Tu5, onTu5);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.We5, onWe5);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Th5, onTh5);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Fr5, onFr5);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Sa5, onSa5);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Su5, onSu5);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Mo6, onMo6);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Tu6, onTu6);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.We6, onWe6);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Th6, onTh6);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Fr6, onFr6);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Sa6, onSa6);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Su6, onSu6);

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

        public event EventHandler<UIEventArgs> ET0;
        private void onET0(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = ET0;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> ET1;
        private void onET1(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = ET1;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> ET2;
        private void onET2(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = ET2;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> ET3;
        private void onET3(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = ET3;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> ET4;
        private void onET4(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = ET4;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> ET5;
        private void onET5(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = ET5;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> ET6;
        private void onET6(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = ET6;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> ET7;
        private void onET7(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = ET7;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> ET8;
        private void onET8(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = ET8;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> ET9;
        private void onET9(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = ET9;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> ET10;
        private void onET10(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = ET10;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Mo0;
        private void onMo0(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Mo0;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Tu0;
        private void onTu0(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Tu0;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> We0;
        private void onWe0(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = We0;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Th0;
        private void onTh0(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Th0;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Fr0;
        private void onFr0(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Fr0;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Sa0;
        private void onSa0(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Sa0;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Su0;
        private void onSu0(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Su0;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Mo1;
        private void onMo1(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Mo1;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Tu1;
        private void onTu1(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Tu1;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> We1;
        private void onWe1(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = We1;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Th1;
        private void onTh1(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Th1;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Fr1;
        private void onFr1(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Fr1;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Sa1;
        private void onSa1(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Sa1;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Su1;
        private void onSu1(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Su1;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Mo2;
        private void onMo2(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Mo2;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Tu2;
        private void onTu2(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Tu2;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> We2;
        private void onWe2(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = We2;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Th2;
        private void onTh2(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Th2;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Fr2;
        private void onFr2(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Fr2;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Sa2;
        private void onSa2(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Sa2;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Su2;
        private void onSu2(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Su2;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Mo3;
        private void onMo3(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Mo3;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Tu3;
        private void onTu3(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Tu3;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> We3;
        private void onWe3(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = We3;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Th3;
        private void onTh3(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Th3;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Fr3;
        private void onFr3(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Fr3;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Sa3;
        private void onSa3(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Sa3;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Su3;
        private void onSu3(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Su3;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Mo4;
        private void onMo4(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Mo4;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Tu4;
        private void onTu4(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Tu4;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> We4;
        private void onWe4(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = We4;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Th4;
        private void onTh4(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Th4;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Fr4;
        private void onFr4(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Fr4;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Sa4;
        private void onSa4(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Sa4;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Su4;
        private void onSu4(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Su4;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Mo5;
        private void onMo5(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Mo5;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Tu5;
        private void onTu5(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Tu5;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> We5;
        private void onWe5(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = We5;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Th5;
        private void onTh5(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Th5;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Fr5;
        private void onFr5(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Fr5;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Sa5;
        private void onSa5(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Sa5;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Su5;
        private void onSu5(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Su5;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Mo6;
        private void onMo6(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Mo6;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Tu6;
        private void onTu6(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Tu6;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> We6;
        private void onWe6(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = We6;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Th6;
        private void onTh6(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Th6;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Fr6;
        private void onFr6(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Fr6;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Sa6;
        private void onSa6(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Sa6;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Su6;
        private void onSu6(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Su6;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }


        public void ETF0(SchBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.ETF0], this);
            }
        }

        public void ETF1(SchBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.ETF1], this);
            }
        }

        public void ETF2(SchBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.ETF2], this);
            }
        }

        public void ETF3(SchBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.ETF3], this);
            }
        }

        public void ETF4(SchBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.ETF4], this);
            }
        }

        public void ETF5(SchBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.ETF5], this);
            }
        }

        public void ETF6(SchBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.ETF6], this);
            }
        }

        public void ETF7(SchBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.ETF7], this);
            }
        }

        public void ETF8(SchBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.ETF8], this);
            }
        }

        public void ETF9(SchBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.ETF9], this);
            }
        }

        public void ETF10(SchBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.ETF10], this);
            }
        }

        public void fbMo0(SchBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.fbMo0], this);
            }
        }

        public void fbTu0(SchBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.fbTu0], this);
            }
        }

        public void fbWe0(SchBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.fbWe0], this);
            }
        }

        public void fbTh0(SchBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.fbTh0], this);
            }
        }

        public void fbFr0(SchBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.fbFr0], this);
            }
        }

        public void fbSa0(SchBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.fbSa0], this);
            }
        }

        public void fbSu0(SchBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.fbSu0], this);
            }
        }

        public void fbMo1(SchBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.fbMo1], this);
            }
        }

        public void fbTu1(SchBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.fbTu1], this);
            }
        }

        public void fbWe1(SchBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.fbWe1], this);
            }
        }

        public void fbTh1(SchBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.fbTh1], this);
            }
        }

        public void fbFr1(SchBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.fbFr1], this);
            }
        }

        public void fbSa1(SchBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.fbSa1], this);
            }
        }

        public void fbSu1(SchBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.fbSu1], this);
            }
        }

        public void fbMo2(SchBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.fbMo2], this);
            }
        }

        public void fbTu2(SchBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.fbTu2], this);
            }
        }

        public void fbWe2(SchBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.fbWe2], this);
            }
        }

        public void fbTh2(SchBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.fbTh2], this);
            }
        }

        public void fbFr2(SchBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.fbFr2], this);
            }
        }

        public void fbSa2(SchBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.fbSa2], this);
            }
        }

        public void fbSu2(SchBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.fbSu2], this);
            }
        }

        public void fbMo3(SchBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.fbMo3], this);
            }
        }

        public void fbTu3(SchBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.fbTu3], this);
            }
        }

        public void fbWe3(SchBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.fbWe3], this);
            }
        }

        public void fbTh3(SchBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.fbTh3], this);
            }
        }

        public void fbFr3(SchBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.fbFr3], this);
            }
        }

        public void fbSa3(SchBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.fbSa3], this);
            }
        }

        public void fbSu3(SchBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.fbSu3], this);
            }
        }

        public void fbMo4(SchBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.fbMo4], this);
            }
        }

        public void fbTu4(SchBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.fbTu4], this);
            }
        }

        public void fbWe4(SchBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.fbWe4], this);
            }
        }

        public void fbTh4(SchBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.fbTh4], this);
            }
        }

        public void fbFr4(SchBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.fbFr4], this);
            }
        }

        public void fbSa4(SchBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.fbSa4], this);
            }
        }

        public void fbSu4(SchBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.fbSu4], this);
            }
        }

        public void fbMo5(SchBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.fbMo5], this);
            }
        }

        public void fbTu5(SchBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.fbTu5], this);
            }
        }

        public void fbWe5(SchBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.fbWe5], this);
            }
        }

        public void fbTh5(SchBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.fbTh5], this);
            }
        }

        public void fbFr5(SchBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.fbFr5], this);
            }
        }

        public void fbSa5(SchBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.fbSa5], this);
            }
        }

        public void fbSu5(SchBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.fbSu5], this);
            }
        }

        public void fbMo6(SchBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.fbMo6], this);
            }
        }

        public void fbTu6(SchBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.fbTu6], this);
            }
        }

        public void fbWe6(SchBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.fbWe6], this);
            }
        }

        public void fbTh6(SchBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.fbTh6], this);
            }
        }

        public void fbFr6(SchBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.fbFr6], this);
            }
        }

        public void fbSa6(SchBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.fbSa6], this);
            }
        }

        public void fbSu6(SchBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.fbSu6], this);
            }
        }


        public void EN0(SchStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.EN0], this);
            }
        }

        public void EN1(SchStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.EN1], this);
            }
        }

        public void EN2(SchStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.EN2], this);
            }
        }

        public void EN3(SchStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.EN3], this);
            }
        }

        public void EN4(SchStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.EN4], this);
            }
        }

        public void EN5(SchStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.EN5], this);
            }
        }

        public void EN6(SchStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.EN6], this);
            }
        }

        public void EN7(SchStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.EN7], this);
            }
        }

        public void EN8(SchStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.EN8], this);
            }
        }

        public void EN9(SchStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.EN9], this);
            }
        }

        public void EN10(SchStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.EN10], this);
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
            return string.Format("Contract: {0} Component: {1} HashCode: {2} {3}", "Sch", GetType().Name, GetHashCode(), UserObject != null ? "UserObject: " + UserObject : null);
        }

        #endregion

        #region IDisposable

        public bool IsDisposed { get; set; }

        public void Dispose()
        {
            if (IsDisposed)
                return;

            IsDisposed = true;

            ET0 = null;
            ET1 = null;
            ET2 = null;
            ET3 = null;
            ET4 = null;
            ET5 = null;
            ET6 = null;
            ET7 = null;
            ET8 = null;
            ET9 = null;
            ET10 = null;
            Mo0 = null;
            Tu0 = null;
            We0 = null;
            Th0 = null;
            Fr0 = null;
            Sa0 = null;
            Su0 = null;
            Mo1 = null;
            Tu1 = null;
            We1 = null;
            Th1 = null;
            Fr1 = null;
            Sa1 = null;
            Su1 = null;
            Mo2 = null;
            Tu2 = null;
            We2 = null;
            Th2 = null;
            Fr2 = null;
            Sa2 = null;
            Su2 = null;
            Mo3 = null;
            Tu3 = null;
            We3 = null;
            Th3 = null;
            Fr3 = null;
            Sa3 = null;
            Su3 = null;
            Mo4 = null;
            Tu4 = null;
            We4 = null;
            Th4 = null;
            Fr4 = null;
            Sa4 = null;
            Su4 = null;
            Mo5 = null;
            Tu5 = null;
            We5 = null;
            Th5 = null;
            Fr5 = null;
            Sa5 = null;
            Su5 = null;
            Mo6 = null;
            Tu6 = null;
            We6 = null;
            Th6 = null;
            Fr6 = null;
            Sa6 = null;
            Su6 = null;
        }

        #endregion

    }
}
