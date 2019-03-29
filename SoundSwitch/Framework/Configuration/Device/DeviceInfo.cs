using System;
using NAudio.CoreAudioApi;
using Newtonsoft.Json;

namespace SoundSwitch.Framework.Configuration.Device
{
    public class DeviceInfo : IEquatable<DeviceInfo>, IComparable<DeviceInfo>
    {
        public string Name { get;  }
        public string Id { get; }
        public DataFlow Type { get; }

        public string CustomName { get; set; }
        public string CustomIconPath { get; set; }

        [JsonConstructor]
        public DeviceInfo(string name, string id, DataFlow type, string customName = null, string customIconPath = null)
        {
            Name = name;
            Id = id;
            Type = type;

            CustomName = customName;
            CustomIconPath = customIconPath;
        }

        public DeviceInfo(MMDevice device)
        {
            Name = device.FriendlyName;
            Id = device.ID;
            Type = device.DataFlow;
        }

        public bool Equals(DeviceInfo other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Type == other.Type && (string.Equals(Id, other.Id) || string.Equals(Name, other.Name));
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((DeviceInfo) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (int) Type + 1;
                hashCode = (hashCode * 397) ^ (Id != null ? Id.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Name != null ? Name.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (CustomName != null ? CustomName.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (CustomIconPath != null ? CustomIconPath.GetHashCode() : 0);
                return hashCode;
            }
        }

        public static bool operator ==(DeviceInfo left, DeviceInfo right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(DeviceInfo left, DeviceInfo right)
        {
            return !Equals(left, right);
        }


        public int CompareTo(DeviceInfo other)
        {
            if (ReferenceEquals(this, other)) return 0;
            if (ReferenceEquals(null, other)) return 1;
            var typeComparison = Type.CompareTo(other.Type);
            if (typeComparison != 0) return typeComparison;
            var idComparison = string.Compare(Id, other.Id, StringComparison.Ordinal);
            if (idComparison != 0) return idComparison;
            var customNameComparison = string.Compare(CustomName, other.CustomName, StringComparison.Ordinal);
            if (customNameComparison != 0) return customNameComparison;
            var customIconPathComparison = string.Compare(CustomIconPath, other.CustomIconPath, StringComparison.Ordinal);
            if (customIconPathComparison != 0) return customIconPathComparison;
            return string.Compare(Name, other.Name, StringComparison.Ordinal);
        }
     
    }
}