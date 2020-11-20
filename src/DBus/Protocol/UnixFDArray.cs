// Copyright 2017 Steffen Kiess <kiess@ki4.de>
// This software is made available under the MIT License
// See COPYING for details

using System;
using System.Collections.Generic;
using System.IO;

namespace DBus.Protocol
{
	public class UnixFDArray //: IDisposable
	{
		public static readonly int MaxFDs = 16;

		List<UnixFd> fds = new List<UnixFd> ();

		public IList<UnixFd> FDs
		{
			get {
				return fds;
			}
		}

		public void Dispose ()
		{
			for (int i = 0; i < fds.Count; i++) {
				fds[i].Dispose ();
			}
		}

		internal UnixFDArray Clone () {
			var res = new UnixFDArray ();
			foreach (var fd in FDs)
			// TODO(firox263): Find a way to reimplement UnixFd
			Console.WriteLine("We should be cloning the Fd, but we're not. Bad things will happen");
				// res.FDs.Add (fd.Clone ());
			return res;
		}
	}
}

// Local Variables:
// tab-width: 4
// c-basic-offset: 4
// indent-tabs-mode: t
// End:
