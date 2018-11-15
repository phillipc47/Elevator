using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Button
{
	public abstract class Button : IButton
	{
		public ButtonState State { get; private set; }
		public string Descriptor { get; set; }

		protected Button(string descriptor = "")
		{
			Descriptor = descriptor;
			State = ButtonState.Disengaged;
		}

		protected Button(IButton button)
		{
			Descriptor = button.Descriptor;
			State = button.State;
		}

		public void Press()
		{
			State = ButtonState.Engaged;
		}
	}
}
