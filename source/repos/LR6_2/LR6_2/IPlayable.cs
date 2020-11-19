using System;
using System.Collections.Generic;
using System.Text;

namespace LR6_2
{
	public interface IPlayable : IMedia
	{
		void Play();
		void Pause();
		void Stop();
	}
}
