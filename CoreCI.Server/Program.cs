﻿/*
 * Copyright (C) 2013 Christian Hoffmeister
 *
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program. If not, see {http://www.gnu.org/licenses/}.
 */
using System;
using System.Threading.Tasks;
using System.Threading;
using CoreCI.Server.VirtualMachines;

namespace CoreCI.Server
{
    /// <summary>
    /// Server executable.
    /// </summary>
    class MainClass
    {
        /// <summary>
        /// Main entry point.
        /// </summary>
        /// <param name="args">The command-line arguments.</param>
        public static void Main(string[] args)
        {
            using (var vm = new VagrantVirtualMachine("precise64", new Uri("http://files.vagrantup.com/precise64.box"), 2, 1024))
            {
                vm.Up();
                int exitCode = vm.Execute("sudo apt-get install -y git").Result;
                vm.Down();
            }
        }
    }
}
