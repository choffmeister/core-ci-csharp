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
using System;
using System.Text;

namespace CoreCI.Common.Shell
{
    public interface IShellOutput : IDisposable
    {
        void WriteStandardInput(string s);

        void WriteStandardOutput(string s);

        void WriteStandardError(string s);
    }

    public class NullShellOutput : IShellOutput
    {
        public void WriteStandardInput(string s)
        {
        }

        public void WriteStandardOutput(string s)
        {
        }

        public void WriteStandardError(string s)
        {
        }

        public void Dispose()
        {
        }
    }

    public class MemoryShellOutput : IShellOutput
    {
        private readonly StringBuilder _standardInput = new StringBuilder();
        private readonly StringBuilder _standardOutput = new StringBuilder();
        private readonly StringBuilder _standardError = new StringBuilder();

        public string StandardInput { get { return _standardInput.ToString(); } }

        public string StandardOutput { get { return _standardOutput.ToString(); } }

        public string StandardError { get { return _standardError.ToString(); } }

        public void WriteStandardInput(string s)
        {
            _standardInput.Append(s);
        }

        public void WriteStandardOutput(string s)
        {
            _standardOutput.Append(s);
        }

        public void WriteStandardError(string s)
        {
            _standardError.Append(s);
        }

        public void Dispose()
        {
        }
    }
}
