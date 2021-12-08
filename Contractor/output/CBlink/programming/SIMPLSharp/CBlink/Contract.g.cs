using System;
using System.Collections.Generic;
using System.Linq;
using Crestron.SimplSharpPro.DeviceSupport;
using Crestron.SimplSharpPro;

namespace CBlink
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

        public CBlink.IArea Area { get { return (CBlink.IArea)InternalArea; } }
        private CBlink.Area InternalArea { get; set; }

        public CBlink.IScenes Scenes { get { return (CBlink.IScenes)InternalScenes; } }
        private CBlink.Scenes InternalScenes { get; set; }

        public CBlink.IZones Zones { get { return (CBlink.IZones)InternalZones; } }
        private CBlink.Zones InternalZones { get; set; }

        public CBlink.ISch Sch { get { return (CBlink.ISch)InternalSch; } }
        private CBlink.Sch InternalSch { get; set; }

        public CBlink.IZonerename Zonerename { get { return (CBlink.IZonerename)InternalZonerename; } }
        private CBlink.Zonerename InternalZonerename { get; set; }

        public CBlink.IPinpad Pinpad { get { return (CBlink.IPinpad)InternalPinpad; } }
        private CBlink.Pinpad InternalPinpad { get; set; }

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

            InternalArea = new CBlink.Area(ComponentMediator, 1);
            InternalScenes = new CBlink.Scenes(ComponentMediator, 2);
            InternalZones = new CBlink.Zones(ComponentMediator, 3);
            InternalSch = new CBlink.Sch(ComponentMediator, 4);
            InternalZonerename = new CBlink.Zonerename(ComponentMediator, 5);
            InternalPinpad = new CBlink.Pinpad(ComponentMediator, 6);

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
