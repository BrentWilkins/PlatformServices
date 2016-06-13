using System;

namespace PlatformServices
{
	public interface ITextToSpeech
	{
		// Note: interface members are public by default
		void Speak (string text, double pitch);
	}
}

