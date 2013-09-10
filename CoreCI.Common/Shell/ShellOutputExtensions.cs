/*
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
namespace CoreCI.Common.Shell
{
    public static class ShellOutputExtensions
    {
        public static void WriteStandardInput(this IShellOutput shellOutput, string fmt, params object[] args)
        {
            shellOutput.WriteStandardInput(string.Format(fmt, args));
        }

        public static void WriteStandardOutput(this IShellOutput shellOutput, string fmt, params object[] args)
        {
            shellOutput.WriteStandardOutput(string.Format(fmt, args));
        }

        public static void WriteStandardError(this IShellOutput shellOutput, string fmt, params object[] args)
        {
            shellOutput.WriteStandardError(string.Format(fmt, args));
        }
    }
}