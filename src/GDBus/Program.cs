using System;
using GLib;
using Gio;

namespace GDBus
{
    class Program
    {
        static void Main(string[] args)
        {
            var bus = DBusConnection.Get(BusType.Session);
            // using var parameters = new Variant(
            //     Variant.Create("AppName"),
            //     Variant.Create(0u),
            //     Variant.Create(""), //Icon
            //     Variant.Create("Summary"),
            //     Variant.Create("Body"),
            //     Variant.Create(new string[0]),
            //     Variant.CreateEmptyDictionary(VariantType.String, VariantType.Variant),//hints
            //     Variant.Create(999)
            // );

            using Variant ret = bus.Call("org.freedesktop.DBus", "/org/freedesktop/DBus", "org.freedesktop.DBus", "ListNames");
            Console.WriteLine(ret.ToString());
        }
    }
}
