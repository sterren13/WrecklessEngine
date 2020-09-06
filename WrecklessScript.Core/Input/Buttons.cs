﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WrecklessScript.Core.Input
{
	public enum Button
	{
		GAMEPAD_ARROW_UP = 0x0001,
		GAMEPAD_ARROW_DOWN = 0x0002,
		GAMEPAD_ARROW_LEFT = 0x0004,
		GAMEPAD_ARROW_RIGHT = 0x0008,
		GAMEPAD_START = 0x0010,
		GAMEPAD_BACK = 0x0020,
		GAMEPAD_LEFT_THUMB = 0x0040,
		GAMEPAD_RIGHT_THUMB = 0x0080,
		GAMEPAD_LEFT_SHOULDER = 0x0100,
		GAMEPAD_RIGHT_SHOULDER = 0x0200,
		GAMEPAD_A = 0x1000,
		GAMEPAD_B = 0x2000,
		GAMEPAD_X = 0x4000,
		GAMEPAD_Y = 0x8000
	};
}