using DigitalMatterPracticalExercise.Models;

namespace DigitalMatterPracticalExercise.Data;

public static class DataSeed
{
    public static void PopulateDatabase(AdminContext context)
    {
        // Check if database has any devices.
        if (context.Devices.Any())
        {
            return; // Already populated.
        }

        // Populate device stable.
        var devices = new Device[]
        {
            new Device {
                Name = "Barra Core",
                Description = "Lowest-cost battery-powered indoor/outdoor asset tracker for NB-IoT networks",
            },
            new Device {
                Name = "Barra Edge",
                Description = "Low-cost battery-powered indoor/outdoor asset tracker for LTE-M/NB-IoT networks",
            },
            new Device {
                Name = "Barra GPS",
                Description = "Low-cost battery-powered outdoor asset tracker for LTE-M/NB-IoT networks",
            },
            new Device {
                Name = "Bolt2",
                Description = "Plug-and-play OBDII GPS tracking device with backup battery for real-time vehicle and fleet management",
            },
            new Device {
                Name = "Dart3",
                Description = "Robust and affordable vehicle tracking device with inputs/outputs, remote immobilization for fleet management, driver ID, driver safety and behavior monitoring, theft recovery, and more",
            },
            new Device {
                Name = "G150 Global",
                Description = "Robust real-time GPS tracking device with Bluetooth® Gateway, inputs/outputs, driver ID and behavior monitoring, remote immobilization, and global connectivity, offering comprehensive vehicle and equipment tracking in rugged conditions with optional Iridium satellite coverage.",
            },
            new Device {
                Name = "G62 for LoRaWAN®",
                Description = "Robust and ultra-rugged vehicle and heavy equipment tracking device with inputs/outputs for fleet management, equipment monitoring on LoRaWAN® networks",
            },
            new Device {
                Name = "G70",
                Description = "Rugged and robust vehicle, trailer, or heavy equipment tracking device with inputs/outputs, remote immobilization for fleet management, equipment monitoring, driver ID, theft recovery, and more",
            },
            new Device {
                Name = "Hawk",
                Description = "The Hawk is a robust plug-and-play IoT data logger and sensor hub for cellular LTE-M/NB-IoT networks designed to support an extensive range of sensor integrations.",
            },
            new Device {
                Name = "Oyster Edge",
                Description = "Ultra-rugged, Indoor/Outdoor battery-powered GPS asset tracking device and Bluetooth® Gateway. Features cloud-based location solving for 10+ years of battery life.",
            },
            new Device {
                Name = "Oyster3",
                Description = "Next-generation of our best-selling Oyster series – Ultra-rugged battery-powered GPS asset tracking device featuring 10+ years battery life",
            },
            new Device {
                Name = "Oyster3 Bluetooth",
                Description = "Our best-selling Oyster series with added Bluetooth functionality – Ultra-rugged and robust GPS asset tracking device and Bluetooth Low Energy Gateway featuring 10+ years battery life",
            },
            new Device {
                Name = "Oyster3 for LoRaWAN®",
                Description = "Ultra-rugged battery-powered GPS asset tracking device for LoRaWAN networks featuring 10 years battery life",
            },
            new Device {
                Name = "Oyster3 Global",
                Description = "Long-life and ultra-rugged battery-powered GPS device for global asset tracking applications",
            },
            new Device {
                Name = "Remora3",
                Description = "Ultra-rugged, long-life battery-powered GPS asset tracking device and Bluetooth® Gateway featuring 10+ years of battery life and tamper detect",
            },
            new Device {
                Name = "Remora3 Global",
                Description = "Long-life and ultra-rugged battery-powered GPS and Bluetooth® gateway for global asset tracking and condition monitoring applications",
            },
            new Device {
                Name = "Yabby Edge Cellular",
                Description = "Ultra-rugged and compact Indoor/Outdoor battery-powered asset tracker. Features cloud-based location solving for over 10 years of battery life.",
            },
            new Device {
                Name = "Yabby Edge for LoRaWAN®",
                Description = "Ultra-rugged and compact Indoor/Outdoor battery-powered asset tracker. Features cloud-based location solving for over 10+ years of battery life.",
            },
            new Device {
                Name = "Yabby3 for LoRaWAN®",
                Description = "Ultra-rugged and compact battery-powered GPS asset tracking device for LoRaWAN® networks featuring 7 years battery life (4x battery life of previous generation)",
            },
            new Device {
                Name = "Yabby3 GPS",
                Description = "Compact and ultra-rugged battery-powered GPS asset tracker featuring 10+ years battery life",
            },
        };
        context.Devices.AddRange(devices);
        context.SaveChanges();

        // Populate firmware table.
        var firmware = new Firmware[]
        {
            new Firmware {
                Version = "v1.0",
                ReleaseDate = DateTime.Parse("2016-06-12"),
                Description = "Initial release",
                Device = devices[0],
            },
            new Firmware {
                Version = "v2.0",
                ReleaseDate = DateTime.Parse("2017-07-01"),
                Description = "Major feature update",
                Device = devices[0],
            },
            new Firmware {
                Version = "v2.1",
                ReleaseDate = DateTime.Parse("2017-08-06"),
                Description = "Bug fixes",
                Device = devices[0],
            },
            new Firmware {
                Version = "v2.1.1",
                ReleaseDate = DateTime.Parse("2017-08-13"),
                Description = "Minor bug fixes",
                Device = devices[0],
            },
            new Firmware {
                Version = "v2.2",
                ReleaseDate = DateTime.Parse("2017-10-01"),
                Description = "Additional bug fixes",
                Device = devices[0],
            },
            new Firmware {
                Version = "v3.0",
                ReleaseDate = DateTime.Parse("2019-01-25"),
                Description = "Next major update",
                Device = devices[0],
            },
            new Firmware {
                Version = "v1.0",
                ReleaseDate = DateTime.Parse("2010-05-05"),
                Description = "Initial release",
                Device = devices[1],
            },
            new Firmware {
                Version = "v1.1",
                ReleaseDate = DateTime.Parse("2010-07-30"),
                Description = "Bug fixes",
                Device = devices[1],
            },
            new Firmware {
                Version = "v2.0",
                ReleaseDate = DateTime.Parse("2012-05-30"),
                Description = "Major feature update",
                Device = devices[1],
            },
            new Firmware {
                Version = "v2.1",
                ReleaseDate = DateTime.Parse("2012-06-04"),
                Description = "Bug fixes",
                Device = devices[1],
            },
            new Firmware {
                Version = "v2.2",
                ReleaseDate = DateTime.Parse("2012-06-08"),
                Description = "More bug fixes",
                Device = devices[1],
            },
            new Firmware {
                Version = "v2.2.1",
                ReleaseDate = DateTime.Parse("2012-07-09"),
                Description = "Additional bug fixes",
                Device = devices[1],
            },
            new Firmware {
                Version = "v2.2.2",
                ReleaseDate = DateTime.Parse("2012-08-01"),
                Description = "Final bug fixes",
                Device = devices[1],
            },
            new Firmware {
                Version = "v1.0",
                ReleaseDate = DateTime.Parse("2020-06-08"),
                Description = "Initial release",
                Device = devices[2],
            },
            new Firmware {
                Version = "v2.0",
                ReleaseDate = DateTime.Parse("2021-05-11"),
                Description = "Major feature update",
                Device = devices[2],
            },
            new Firmware {
                Version = "v3.0",
                ReleaseDate = DateTime.Parse("2022-06-15"),
                Description = "Tertiary feature update",
                Device = devices[2],
            },
            new Firmware {
                Version = "v4.0",
                ReleaseDate = DateTime.Parse("2023-02-13"),
                Description = "Quaternary feature update",
                Device = devices[2],
            },
            new Firmware {
                Version = "v1.0",
                ReleaseDate = DateTime.Parse("2015-05-05"),
                Description = "Initial release",
                Device = devices[3],
            },
            new Firmware {
                Version = "v2.0",
                ReleaseDate = DateTime.Parse("2016-05-05"),
                Description = "Major feature update",
                Device = devices[3],
            },
            new Firmware {
                Version = "v2.1",
                ReleaseDate = DateTime.Parse("2016-06-05"),
                Description = "Bug fixes",
                Device = devices[3],
            },
            new Firmware {
                Version = "v2.2",
                ReleaseDate = DateTime.Parse("2016-07-05"),
                Description = "Additional bug fixes",
                Device = devices[3],
            },
        };
        context.Firmware.AddRange(firmware);
        context.SaveChanges();

        // Root groups have no parent groups.
        var roots = new Group[]
        {
            new Group {
                Name = "Power",
                Description = "Device category",
            },
            new Group {
                Name = "Connectivity",
                Description = "Device category",
            },
            new Group {
                Name = "Features",
                Description = "Device category",
            },
            new Group {
                Name = "Applications",
                Description = "Device category",
            },
        };

        // Populate groups table.
        var groups = new Group[]
        {
            roots[0],
            roots[1],
            roots[2],
            roots[3],
            new Group {
                Name = "Battery-Powered",
                Description = "Power type",
                ParentGroup = roots[0],
            },
            new Group {
                Name = "OBDII",
                Description = "Power type",
                ParentGroup = roots[0],
            },
            new Group {
                Name = "Wired",
                Description = "Power type",
                ParentGroup = roots[0],
            },
            new Group {
                Name = "2G",
                Description = "Connectivity type",
                ParentGroup = roots[1],
            },
            new Group {
                Name = "4G Cat 1bis / 2G Fallback",
                Description = "Connectivity type",
                ParentGroup = roots[1],
            },
            new Group {
                Name = "Iridium Satellite",
                Description = "Connectivity type",
                ParentGroup = roots[1],
            },
            new Group {
                Name = "LoRaWAN®",
                Description = "Connectivity type",
                ParentGroup = roots[1],
            },
            new Group {
                Name = "LTE-M (Cat-M1) / NB-IoT",
                Description = "Connectivity type",
                ParentGroup = roots[1],
            },
            new Group {
                Name = "NB-IoT Only",
                Description = "Connectivity type",
                ParentGroup = roots[1],
            },
            new Group {
                Name = "1-Wire® or iButton®",
                Description = "Type of feature",
                ParentGroup = roots[2],
            },
            new Group {
                Name = "3-Axis Accelerometer",
                Description = "Type of feature",
                ParentGroup = roots[2],
            },
            new Group {
                Name = "4-20mA Inputs",
                Description = "Type of feature",
                ParentGroup = roots[2],
            },
            new Group {
                Name = "Analog Inputs",
                Description = "Type of feature",
                ParentGroup = roots[2],
            },
            new Group {
                Name = "Bluetooth®",
                Description = "Type of feature",
                ParentGroup = roots[2],
            },
            new Group {
                Name = "Digital Inputs",
                Description = "Type of feature",
                ParentGroup = roots[2],
            },
            new Group {
                Name = "Digital Outputs",
                Description = "Type of feature",
                ParentGroup = roots[2],
            },
            new Group {
                Name = "I²C Sensor Interface",
                Description = "Type of feature",
                ParentGroup = roots[2],
            },
            new Group {
                Name = "Indoor / Outdoor",
                Description = "Type of feature",
                ParentGroup = roots[2],
            },
            new Group {
                Name = "IP68 Rated",
                Description = "Type of feature",
                ParentGroup = roots[2],
            },
            new Group {
                Name = "OBDII",
                Description = "Type of feature",
                ParentGroup = roots[2],
            },
            new Group {
                Name = "RS-232 Interface",
                Description = "Type of feature",
                ParentGroup = roots[2],
            },
            new Group {
                Name = "RS-485 Interface",
                Description = "Type of feature",
                ParentGroup = roots[2],
            },
            new Group {
                Name = "SDI-12 Interface",
                Description = "Type of feature",
                ParentGroup = roots[2],
            },
            new Group {
                Name = "Switched Power Out",
                Description = "Type of feature",
                ParentGroup = roots[2],
            },
            new Group {
                Name = "Vehicle Access Control",
                Description = "Type of feature",
                ParentGroup = roots[2],
            },
            new Group {
                Name = "Wiegand Interface",
                Description = "Type of feature",
                ParentGroup = roots[2],
            },
            new Group {
                Name = "Accident Detection",
                Description = "Type of application",
                ParentGroup = roots[3],
            },
            new Group {
                Name = "Cold Chain",
                Description = "Type of application",
                ParentGroup = roots[3],
            },
            new Group {
                Name = "Driver Behavior",
                Description = "Type of application",
                ParentGroup = roots[3],
            },
            new Group {
                Name = "Driver ID",
                Description = "Type of application",
                ParentGroup = roots[3],
            },
            new Group {
                Name = "Equipment Tracking",
                Description = "Type of application",
                ParentGroup = roots[3],
            },
            new Group {
                Name = "Fleet Management",
                Description = "Type of application",
                ParentGroup = roots[3],
            },
            new Group {
                Name = "In-Vehicle Alerts",
                Description = "Type of application",
                ParentGroup = roots[3],
            },
            new Group {
                Name = "Non-Powered Asset Tracking",
                Description = "Type of application",
                ParentGroup = roots[3],
            },
            new Group {
                Name = "Remote Immobilization",
                Description = "Type of application",
                ParentGroup = roots[3],
            },
            new Group {
                Name = "Sensor Monitoring",
                Description = "Type of application",
                ParentGroup = roots[3],
            },
            new Group {
                Name = "Trailer Tracking",
                Description = "Type of application",
                ParentGroup = roots[3],
            },
        };
        context.Groups.AddRange(groups);
        context.SaveChanges();

        // Populate connections table.
        var connections = new Connection[]
        {
            new Connection {
                Group = groups[4],
                Device = devices[0],
            },
            new Connection {
                Group = groups[4],
                Device = devices[1],
            },
            new Connection {
                Group = groups[4],
                Device = devices[2],
            },
            new Connection {
                Group = groups[5],
                Device = devices[3],
            },
            new Connection {
                Group = groups[4],
                Device = devices[8],
            },
            new Connection {
                Group = groups[6],
                Device = devices[8],
            },
            new Connection {
                Group = groups[8],
                Device = devices[5],
            },
            new Connection {
                Group = groups[8],
                Device = devices[13],
            },
            new Connection {
                Group = groups[8],
                Device = devices[15],
            },
            new Connection {
                Group = groups[14],
                Device = devices[0],
            },
            new Connection {
                Group = groups[14],
                Device = devices[1],
            },
            new Connection {
                Group = groups[14],
                Device = devices[2],
            },
            new Connection {
                Group = groups[22],
                Device = devices[0],
            },
            new Connection {
                Group = groups[22],
                Device = devices[1],
            },
            new Connection {
                Group = groups[22],
                Device = devices[2],
            },
            new Connection {
                Group = groups[39],
                Device = devices[5],
            },
            new Connection {
                Group = groups[39],
                Device = devices[8],
            },
        };
        context.Connections.AddRange(connections);
        context.SaveChanges();
    }
}
