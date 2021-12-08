using System;
using System.Collections.Generic;
using System.Linq;
using Crestron.SimplSharpPro.DeviceSupport;
using Crestron.SimplSharpPro;

namespace CBLINK
{
    /// <summary>
    /// Common Interface for Root Contracts.
    /// </summary>
    public interface IContract
    {
        object UserObject { get; set; }
        void AddDevice(BasicTriListWithSmartObject device);
        void RemoveDevice(BasicTriListWithSmartObject device);
    }

    public class Contract : IContract, IDisposable
    {
        #region Components

        private ComponentMediator ComponentMediator { get; set; }

        public CBLINK.IArea Area { get { return (CBLINK.IArea)InternalArea; } }
        private CBLINK.Area InternalArea { get; set; }

        public CBLINK.IScenes Scenes { get { return (CBLINK.IScenes)InternalScenes; } }
        private CBLINK.Scenes InternalScenes { get; set; }

        public CBLINK.IZones Zones { get { return (CBLINK.IZones)InternalZones; } }
        private CBLINK.Zones InternalZones { get; set; }

        public CBLINK.ISch Sch { get { return (CBLINK.ISch)InternalSch; } }
        private CBLINK.Sch InternalSch { get; set; }

        public CBLINK.IZonerename Zonerename { get { return (CBLINK.IZonerename)InternalZonerename; } }
        private CBLINK.Zonerename InternalZonerename { get; set; }

        public CBLINK.IPinpad Pinpad { get { return (CBLINK.IPinpad)InternalPinpad; } }
        private CBLINK.Pinpad InternalPinpad { get; set; }

        #endregion

        #region Construction and Initialization

        public Contract()
            : this(new List<BasicTriListWithSmartObject>().ToArray())
        {
        }

        public Contract(BasicTriListWithSmartObject device)
            : this(new [] { device })
        {
        }

        public Contract(BasicTriListWithSmartObject[] devices)
        {
            if (devices == null)
                throw new ArgumentNullException("Devices is null");

            ComponentMediator = new ComponentMediator();

            InternalArea = new CBLINK.Area(ComponentMediator, 1);
            InternalScenes = new CBLINK.Scenes(ComponentMediator, 2);
            InternalZones = new CBLINK.Zones(ComponentMediator, 3);
            InternalSch = new CBLINK.Sch(ComponentMediator, 4);
            InternalZonerename = new CBLINK.Zonerename(ComponentMediator, 5);
            InternalPinpad = new CBLINK.Pinpad(ComponentMediator, 6);

            for (int index = 0; index < devices.Length; index++)
            {
                AddDevice(devices[index]);
            }
        }

        #endregion

        #region Standard Contract Members

        public object UserObject { get; set; }

        public void AddDevice(BasicTriListWithSmartObject device)
        {
            InternalArea.AddDevice(device);
            InternalScenes.AddDevice(device);
            InternalZones.AddDevice(device);
            InternalSch.AddDevice(device);
            InternalZonerename.AddDevice(device);
            InternalPinpad.AddDevice(device);
        }

        public void RemoveDevice(BasicTriListWithSmartObject device)
        {
            InternalArea.RemoveDevice(device);
            InternalScenes.RemoveDevice(device);
            InternalZones.RemoveDevice(device);
            InternalSch.RemoveDevice(device);
            InternalZonerename.RemoveDevice(device);
            InternalPinpad.RemoveDevice(device);
        }

        #endregion

        #region IDisposable

        public bool IsDisposed { get; set; }

        public void Dispose()
        {
            if (IsDisposed)
                return;

            IsDisposed = true;

            InternalArea.Dispose();
            InternalScenes.Dispose();
            InternalZones.Dispose();
            InternalSch.Dispose();
            InternalZonerename.Dispose();
            InternalPinpad.Dispose();
            ComponentMediator.Dispose(); 
        }

        #endregion

    }
}
