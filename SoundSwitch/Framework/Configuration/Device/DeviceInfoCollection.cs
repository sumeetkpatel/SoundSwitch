﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using NAudio.CoreAudioApi;

namespace SoundSwitch.Framework.Configuration.Device
{
    public class DeviceInfoCollection : ICollection<DeviceInfo>
    {
        private readonly Dictionary<string, DeviceInfo> _deviceByName = new Dictionary<string, DeviceInfo>();
        private readonly Dictionary<string, DeviceInfo> _deviceById = new Dictionary<string, DeviceInfo>();

        private readonly HashSet<DeviceInfo> _original;

        public DeviceInfoCollection(HashSet<DeviceInfo> devices)
        {
            _original = devices;
            foreach (var deviceInfo in devices)
            {
                AddItem(deviceInfo);
            }
        }

        /// <summary>
        /// Intersect with MMDevices
        /// </summary>
        /// <param name="devices"></param>
        /// <returns></returns>
        public ICollection<DeviceFullInfo> IntersectWith(IEnumerable<DeviceFullInfo> devices)
        {
            var devicesResult = new Dictionary<string, DeviceFullInfo>();
            foreach (var device in devices)
            {
                //No duplicates
                if (devicesResult.ContainsKey(device.Id))
                    continue;

                //Both dictionaries dont have it
                if (!_deviceById.ContainsKey(device.Id) && !_deviceByName.ContainsKey(device.Name))
                    continue;

                //Id dictionary has it
                if (_deviceById.ContainsKey(device.Id))
                {
                    //Just add the custom properties to the system device
                    DeviceInfo deviceInfo = _deviceById[device.Id];
                    device.CustomName = deviceInfo.CustomName;
                    device.CustomIconPath = deviceInfo.CustomIconPath;
                }

                //Name dictionary has it
                if (_deviceByName.ContainsKey(device.Name))
                {
                    //Just add the custom properties to the system device
                    DeviceInfo deviceInfo = _deviceByName[device.Name];
                    device.CustomName = deviceInfo.CustomName;
                    device.CustomIconPath = deviceInfo.CustomIconPath;
                }

                devicesResult.Add(device.Id, device);
            }

            return devicesResult.Values;

        }

        public IEnumerator<DeviceInfo> GetEnumerator()
        {
            return _deviceById.Values.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(DeviceInfo item)
        {
            AddItem(item, true);
        }

        public void Add(MMDevice item)
        {
            AddItem(new DeviceInfo(item), true);
        }

        /// <summary>
        /// Add Item and update or not the original
        /// </summary>
        /// <param name="item"></param>
        /// <param name="updateOriginal"></param>
        private void AddItem(DeviceInfo item, bool updateOriginal = false)
        {
            if (item == null)
            {
                return;
            }

            try
            {
                _deviceById.Add(item.Id, item);
            }
            catch (ArgumentException)
            {
            }

            try
            {
                _deviceByName.Add(item.Name, item);
            }
            catch (ArgumentException)
            {
            }

            if (updateOriginal)
            {
                _original.Add(item);
            }
        }

        public void Clear()
        {
            _deviceById.Clear();
            _deviceByName.Clear();
            _original.Clear();
        }

        public bool Contains(DeviceInfo item)
        {
            return item != null && (_deviceById.ContainsKey(item.Id) || _deviceByName.ContainsKey(item.Name));
        }

        public bool UpdateCustomProperties(DeviceInfo item)
        {
            if (this.Contains(item)){
                DeviceInfo existingItem = _deviceById[item.Id];
                existingItem.CustomName = item.CustomName;
                existingItem.CustomIconPath = item.CustomIconPath;
                return true;
            }
            return false;
        }

        public void CopyTo(DeviceInfo[] array, int arrayIndex)
        {
            throw new System.NotImplementedException();
        }

        public bool Remove(DeviceInfo item)
        {
            if (item == null)
            {
                return false;
            }

            var result = _original.RemoveWhere((info => info?.Id == item.Id || info?.Name == item.Name)) > 0;

            try
            {
                result &= _deviceById.Remove(item.Id);
            }
            catch (ArgumentException)
            {

            }

            try
            {
                result &= _deviceByName.Remove(item.Name);
            }
            catch (ArgumentException)
            {

            }

            return result;
        }

        public int Count => _deviceById.Count;

        public bool IsReadOnly => false;
    }
}