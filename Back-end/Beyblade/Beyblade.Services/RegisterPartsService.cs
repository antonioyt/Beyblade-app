﻿using Beyblade.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Beyblade.Services
{
    public partial class BeybladeContext
    {
        public void RegisterLayer(Layer layer)
        {
            Layers.Add(layer);
            SaveChanges();
        }

        public void RegisterDisk(Disk disk)
        {
            Disks.Add(disk);
            SaveChanges();
        }

        public void RegisterFrame(Frame frame)
        {
            Frames.Add(frame);
            SaveChanges();
        }

        public void RegisterDriver(Driver driver)
        {
            Drivers.Add(driver);
            SaveChanges();
        }
    }
}