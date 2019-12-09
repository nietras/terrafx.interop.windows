// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/hidusage.h in the Windows SDK for Windows 10.0.18632.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        public const ushort HID_USAGE_PAGE_UNDEFINED = 0x00;

        public const ushort HID_USAGE_PAGE_GENERIC = 0x01;

        public const ushort HID_USAGE_PAGE_SIMULATION = 0x02;

        public const ushort HID_USAGE_PAGE_VR = 0x03;

        public const ushort HID_USAGE_PAGE_SPORT = 0x04;

        public const ushort HID_USAGE_PAGE_GAME = 0x05;

        public const ushort HID_USAGE_PAGE_GENERIC_DEVICE = 0x06;

        public const ushort HID_USAGE_PAGE_KEYBOARD = 0x07;

        public const ushort HID_USAGE_PAGE_LED = 0x08;

        public const ushort HID_USAGE_PAGE_BUTTON = 0x09;

        public const ushort HID_USAGE_PAGE_ORDINAL = 0x0A;

        public const ushort HID_USAGE_PAGE_TELEPHONY = 0x0B;

        public const ushort HID_USAGE_PAGE_CONSUMER = 0x0C;

        public const ushort HID_USAGE_PAGE_DIGITIZER = 0x0D;

        public const ushort HID_USAGE_PAGE_HAPTICS = 0x0E;

        public const ushort HID_USAGE_PAGE_PID = 0x0F;

        public const ushort HID_USAGE_PAGE_UNICODE = 0x10;

        public const ushort HID_USAGE_PAGE_ALPHANUMERIC = 0x14;

        public const ushort HID_USAGE_PAGE_SENSOR = 0x20;

        public const ushort HID_USAGE_PAGE_LIGHTING_ILLUMINATION = 0x59;

        public const ushort HID_USAGE_PAGE_BARCODE_SCANNER = 0x8C;

        public const ushort HID_USAGE_PAGE_WEIGHING_DEVICE = 0x8D;

        public const ushort HID_USAGE_PAGE_MAGNETIC_STRIPE_READER = 0x8E;

        public const ushort HID_USAGE_PAGE_CAMERA_CONTROL = 0x90;

        public const ushort HID_USAGE_PAGE_ARCADE = 0x91;

        public const ushort HID_USAGE_PAGE_MICROSOFT_BLUETOOTH_HANDSFREE = 0xFFF3;

        public const ushort HID_USAGE_PAGE_VENDOR_DEFINED_BEGIN = 0xFF00;

        public const ushort HID_USAGE_PAGE_VENDOR_DEFINED_END = 0xFFFF;

        public const ushort HID_USAGE_GENERIC_POINTER = 0x01;

        public const ushort HID_USAGE_GENERIC_MOUSE = 0x02;

        public const ushort HID_USAGE_GENERIC_JOYSTICK = 0x04;

        public const ushort HID_USAGE_GENERIC_GAMEPAD = 0x05;

        public const ushort HID_USAGE_GENERIC_KEYBOARD = 0x06;

        public const ushort HID_USAGE_GENERIC_KEYPAD = 0x07;

        public const ushort HID_USAGE_GENERIC_MULTI_AXIS_CONTROLLER = 0x08;

        public const ushort HID_USAGE_GENERIC_TABLET_PC_SYSTEM_CTL = 0x09;

        public const ushort HID_USAGE_GENERIC_PORTABLE_DEVICE_CONTROL = 0x0D;

        public const ushort HID_USAGE_GENERIC_INTERACTIVE_CONTROL = 0x0E;

        public const ushort HID_USAGE_GENERIC_COUNTED_BUFFER = 0x3A;

        public const ushort HID_USAGE_GENERIC_SYSTEM_CTL = 0x80;

        public const ushort HID_USAGE_GENERIC_X = 0x30;

        public const ushort HID_USAGE_GENERIC_Y = 0x31;

        public const ushort HID_USAGE_GENERIC_Z = 0x32;

        public const ushort HID_USAGE_GENERIC_RX = 0x33;

        public const ushort HID_USAGE_GENERIC_RY = 0x34;

        public const ushort HID_USAGE_GENERIC_RZ = 0x35;

        public const ushort HID_USAGE_GENERIC_SLIDER = 0x36;

        public const ushort HID_USAGE_GENERIC_DIAL = 0x37;

        public const ushort HID_USAGE_GENERIC_WHEEL = 0x38;

        public const ushort HID_USAGE_GENERIC_HATSWITCH = 0x39;

        public const ushort HID_USAGE_GENERIC_BYTE_COUNT = 0x3B;

        public const ushort HID_USAGE_GENERIC_MOTION_WAKEUP = 0x3C;

        public const ushort HID_USAGE_GENERIC_START = 0x3D;

        public const ushort HID_USAGE_GENERIC_SELECT = 0x3E;

        public const ushort HID_USAGE_GENERIC_VX = 0x40;

        public const ushort HID_USAGE_GENERIC_VY = 0x41;

        public const ushort HID_USAGE_GENERIC_VZ = 0x42;

        public const ushort HID_USAGE_GENERIC_VBRX = 0x43;

        public const ushort HID_USAGE_GENERIC_VBRY = 0x44;

        public const ushort HID_USAGE_GENERIC_VBRZ = 0x45;

        public const ushort HID_USAGE_GENERIC_VNO = 0x46;

        public const ushort HID_USAGE_GENERIC_FEATURE_NOTIFICATION = 0x47;

        public const ushort HID_USAGE_GENERIC_RESOLUTION_MULTIPLIER = 0x48;

        public const ushort HID_USAGE_GENERIC_SYSCTL_POWER = 0x81;

        public const ushort HID_USAGE_GENERIC_SYSCTL_SLEEP = 0x82;

        public const ushort HID_USAGE_GENERIC_SYSCTL_WAKE = 0x83;

        public const ushort HID_USAGE_GENERIC_SYSCTL_CONTEXT_MENU = 0x84;

        public const ushort HID_USAGE_GENERIC_SYSCTL_MAIN_MENU = 0x85;

        public const ushort HID_USAGE_GENERIC_SYSCTL_APP_MENU = 0x86;

        public const ushort HID_USAGE_GENERIC_SYSCTL_HELP_MENU = 0x87;

        public const ushort HID_USAGE_GENERIC_SYSCTL_MENU_EXIT = 0x88;

        public const ushort HID_USAGE_GENERIC_SYSCTL_MENU_SELECT = 0x89;

        public const ushort HID_USAGE_GENERIC_SYSCTL_MENU_RIGHT = 0x8A;

        public const ushort HID_USAGE_GENERIC_SYSCTL_MENU_LEFT = 0x8B;

        public const ushort HID_USAGE_GENERIC_SYSCTL_MENU_UP = 0x8C;

        public const ushort HID_USAGE_GENERIC_SYSCTL_MENU_DOWN = 0x8D;

        public const ushort HID_USAGE_GENERIC_SYSCTL_COLD_RESTART = 0x8E;

        public const ushort HID_USAGE_GENERIC_SYSCTL_WARM_RESTART = 0x8F;

        public const ushort HID_USAGE_GENERIC_DPAD_UP = 0x90;

        public const ushort HID_USAGE_GENERIC_DPAD_DOWN = 0x91;

        public const ushort HID_USAGE_GENERIC_DPAD_RIGHT = 0x92;

        public const ushort HID_USAGE_GENERIC_DPAD_LEFT = 0x93;

        public const ushort HID_USAGE_GENERIC_SYSCTL_DISMISS_NOTIFICATION = 0x9A;

        public const ushort HID_USAGE_GENERIC_SYSCTL_DOCK = 0xA0;

        public const ushort HID_USAGE_GENERIC_SYSCTL_UNDOCK = 0xA1;

        public const ushort HID_USAGE_GENERIC_SYSCTL_SETUP = 0xA2;

        public const ushort HID_USAGE_GENERIC_SYSCTL_SYS_BREAK = 0xA3;

        public const ushort HID_USAGE_GENERIC_SYSCTL_SYS_DBG_BREAK = 0xA4;

        public const ushort HID_USAGE_GENERIC_SYSCTL_APP_BREAK = 0xA5;

        public const ushort HID_USAGE_GENERIC_SYSCTL_APP_DBG_BREAK = 0xA6;

        public const ushort HID_USAGE_GENERIC_SYSCTL_MUTE = 0xA7;

        public const ushort HID_USAGE_GENERIC_SYSCTL_HIBERNATE = 0xA8;

        public const ushort HID_USAGE_GENERIC_SYSCTL_DISP_INVERT = 0xB0;

        public const ushort HID_USAGE_GENERIC_SYSCTL_DISP_INTERNAL = 0xB1;

        public const ushort HID_USAGE_GENERIC_SYSCTL_DISP_EXTERNAL = 0xB2;

        public const ushort HID_USAGE_GENERIC_SYSCTL_DISP_BOTH = 0xB3;

        public const ushort HID_USAGE_GENERIC_SYSCTL_DISP_DUAL = 0xB4;

        public const ushort HID_USAGE_GENERIC_SYSCTL_DISP_TOGGLE = 0xB5;

        public const ushort HID_USAGE_GENERIC_SYSCTL_DISP_SWAP = 0xB6;

        public const ushort HID_USAGE_GENERIC_SYSCTL_DISP_AUTOSCALE = 0xB7;

        public const ushort HID_USAGE_GENERIC_SYSTEM_DISPLAY_ROTATION_LOCK_BUTTON = 0xC9;

        public const ushort HID_USAGE_GENERIC_SYSTEM_DISPLAY_ROTATION_LOCK_SLIDER_SWITCH = 0xCA;

        public const ushort HID_USAGE_GENERIC_CONTROL_ENABLE = 0xCB;

        public const ushort HID_USAGE_SIMULATION_FLIGHT_SIMULATION_DEVICE = 0x01;

        public const ushort HID_USAGE_SIMULATION_AUTOMOBILE_SIMULATION_DEVICE = 0x02;

        public const ushort HID_USAGE_SIMULATION_TANK_SIMULATION_DEVICE = 0x03;

        public const ushort HID_USAGE_SIMULATION_SPACESHIP_SIMULATION_DEVICE = 0x04;

        public const ushort HID_USAGE_SIMULATION_SUBMARINE_SIMULATION_DEVICE = 0x05;

        public const ushort HID_USAGE_SIMULATION_SAILING_SIMULATION_DEVICE = 0x06;

        public const ushort HID_USAGE_SIMULATION_MOTORCYCLE_SIMULATION_DEVICE = 0x07;

        public const ushort HID_USAGE_SIMULATION_SPORTS_SIMULATION_DEVICE = 0x08;

        public const ushort HID_USAGE_SIMULATION_AIRPLANE_SIMULATION_DEVICE = 0x09;

        public const ushort HID_USAGE_SIMULATION_HELICOPTER_SIMULATION_DEVICE = 0x0A;

        public const ushort HID_USAGE_SIMULATION_MAGIC_CARPET_SIMULATION_DEVICE = 0x0B;

        public const ushort HID_USAGE_SIMULATION_BICYCLE_SIMULATION_DEVICE = 0x0C;

        public const ushort HID_USAGE_SIMULATION_FLIGHT_CONTROL_STICK = 0x20;

        public const ushort HID_USAGE_SIMULATION_FLIGHT_STICK = 0x21;

        public const ushort HID_USAGE_SIMULATION_CYCLIC_CONTROL = 0x22;

        public const ushort HID_USAGE_SIMULATION_CYCLIC_TRIM = 0x23;

        public const ushort HID_USAGE_SIMULATION_FLIGHT_YOKE = 0x24;

        public const ushort HID_USAGE_SIMULATION_TRACK_CONTROL = 0x25;

        public const ushort HID_USAGE_SIMULATION_AILERON = 0xB0;

        public const ushort HID_USAGE_SIMULATION_AILERON_TRIM = 0xB1;

        public const ushort HID_USAGE_SIMULATION_ANTI_TORQUE_CONTROL = 0xB2;

        public const ushort HID_USAGE_SIMULATION_AUTOPIOLOT_ENABLE = 0xB3;

        public const ushort HID_USAGE_SIMULATION_CHAFF_RELEASE = 0xB4;

        public const ushort HID_USAGE_SIMULATION_COLLECTIVE_CONTROL = 0xB5;

        public const ushort HID_USAGE_SIMULATION_DIVE_BRAKE = 0xB6;

        public const ushort HID_USAGE_SIMULATION_ELECTRONIC_COUNTERMEASURES = 0xB7;

        public const ushort HID_USAGE_SIMULATION_ELEVATOR = 0xB8;

        public const ushort HID_USAGE_SIMULATION_ELEVATOR_TRIM = 0xB9;

        public const ushort HID_USAGE_SIMULATION_RUDDER = 0xBA;

        public const ushort HID_USAGE_SIMULATION_THROTTLE = 0xBB;

        public const ushort HID_USAGE_SIMULATION_FLIGHT_COMMUNICATIONS = 0xBC;

        public const ushort HID_USAGE_SIMULATION_FLARE_RELEASE = 0xBD;

        public const ushort HID_USAGE_SIMULATION_LANDING_GEAR = 0xBE;

        public const ushort HID_USAGE_SIMULATION_TOE_BRAKE = 0xBF;

        public const ushort HID_USAGE_SIMULATION_TRIGGER = 0xC0;

        public const ushort HID_USAGE_SIMULATION_WEAPONS_ARM = 0xC1;

        public const ushort HID_USAGE_SIMULATION_WEAPONS_SELECT = 0xC2;

        public const ushort HID_USAGE_SIMULATION_WING_FLAPS = 0xC3;

        public const ushort HID_USAGE_SIMULATION_ACCELLERATOR = 0xC4;

        public const ushort HID_USAGE_SIMULATION_BRAKE = 0xC5;

        public const ushort HID_USAGE_SIMULATION_CLUTCH = 0xC6;

        public const ushort HID_USAGE_SIMULATION_SHIFTER = 0xC7;

        public const ushort HID_USAGE_SIMULATION_STEERING = 0xC8;

        public const ushort HID_USAGE_SIMULATION_TURRET_DIRECTION = 0xC9;

        public const ushort HID_USAGE_SIMULATION_BARREL_ELEVATION = 0xCA;

        public const ushort HID_USAGE_SIMULATION_DIVE_PLANE = 0xCB;

        public const ushort HID_USAGE_SIMULATION_BALLAST = 0xCC;

        public const ushort HID_USAGE_SIMULATION_BICYCLE_CRANK = 0xCD;

        public const ushort HID_USAGE_SIMULATION_HANDLE_BARS = 0xCE;

        public const ushort HID_USAGE_SIMULATION_FRONT_BRAKE = 0xCF;

        public const ushort HID_USAGE_SIMULATION_REAR_BRAKE = 0xD0;

        public const ushort HID_USAGE_VR_BELT = 0x01;

        public const ushort HID_USAGE_VR_BODY_SUIT = 0x02;

        public const ushort HID_USAGE_VR_FLEXOR = 0x03;

        public const ushort HID_USAGE_VR_GLOVE = 0x04;

        public const ushort HID_USAGE_VR_HEAD_TRACKER = 0x05;

        public const ushort HID_USAGE_VR_HEAD_MOUNTED_DISPLAY = 0x06;

        public const ushort HID_USAGE_VR_HAND_TRACKER = 0x07;

        public const ushort HID_USAGE_VR_OCULOMETER = 0x08;

        public const ushort HID_USAGE_VR_VEST = 0x09;

        public const ushort HID_USAGE_VR_ANIMATRONIC_DEVICE = 0x0A;

        public const ushort HID_USAGE_VR_STEREO_ENABLE = 0x20;

        public const ushort HID_USAGE_VR_DISPLAY_ENABLE = 0x21;

        public const ushort HID_USAGE_SPORT_BASEBALL_BAT = 0x01;

        public const ushort HID_USAGE_SPORT_GOLF_CLUB = 0x02;

        public const ushort HID_USAGE_SPORT_ROWING_MACHINE = 0x03;

        public const ushort HID_USAGE_SPORT_TREADMILL = 0x04;

        public const ushort HID_USAGE_SPORT_STICK_TYPE = 0x38;

        public const ushort HID_USAGE_SPORT_OAR = 0x30;

        public const ushort HID_USAGE_SPORT_SLOPE = 0x31;

        public const ushort HID_USAGE_SPORT_RATE = 0x32;

        public const ushort HID_USAGE_SPORT_STICK_SPEED = 0x33;

        public const ushort HID_USAGE_SPORT_STICK_FACE_ANGLE = 0x34;

        public const ushort HID_USAGE_SPORT_HEEL_TOE = 0x35;

        public const ushort HID_USAGE_SPORT_FOLLOW_THROUGH = 0x36;

        public const ushort HID_USAGE_SPORT_TEMPO = 0x37;

        public const ushort HID_USAGE_SPORT_HEIGHT = 0x39;

        public const ushort HID_USAGE_SPORT_PUTTER = 0x50;

        public const ushort HID_USAGE_SPORT_1_IRON = 0x51;

        public const ushort HID_USAGE_SPORT_2_IRON = 0x52;

        public const ushort HID_USAGE_SPORT_3_IRON = 0x53;

        public const ushort HID_USAGE_SPORT_4_IRON = 0x54;

        public const ushort HID_USAGE_SPORT_5_IRON = 0x55;

        public const ushort HID_USAGE_SPORT_6_IRON = 0x56;

        public const ushort HID_USAGE_SPORT_7_IRON = 0x57;

        public const ushort HID_USAGE_SPORT_8_IRON = 0x58;

        public const ushort HID_USAGE_SPORT_9_IRON = 0x59;

        public const ushort HID_USAGE_SPORT_10_IRON = 0x5A;

        public const ushort HID_USAGE_SPORT_11_IRON = 0x5B;

        public const ushort HID_USAGE_SPORT_SAND_WEDGE = 0x5C;

        public const ushort HID_USAGE_SPORT_LOFT_WEDGE = 0x5D;

        public const ushort HID_USAGE_SPORT_POWER_WEDGE = 0x5E;

        public const ushort HID_USAGE_SPORT_1_WOOD = 0x5F;

        public const ushort HID_USAGE_SPORT_3_WOOD = 0x60;

        public const ushort HID_USAGE_SPORT_5_WOOD = 0x61;

        public const ushort HID_USAGE_SPORT_7_WOOD = 0x62;

        public const ushort HID_USAGE_SPORT_9_WOOD = 0x63;

        public const ushort HID_USAGE_GAME_3D_GAME_CONTROLLER = 0x01;

        public const ushort HID_USAGE_GAME_PINBALL_DEVICE = 0x02;

        public const ushort HID_USAGE_GAME_GUN_DEVICE = 0x03;

        public const ushort HID_USAGE_GAME_POINT_OF_VIEW = 0x20;

        public const ushort HID_USAGE_GAME_GUN_SELECTOR = 0x32;

        public const ushort HID_USAGE_GAME_GAMEPAD_FIRE_JUMP = 0x37;

        public const ushort HID_USAGE_GAME_GAMEPAD_TRIGGER = 0x39;

        public const ushort HID_USAGE_GAME_TURN_RIGHT_LEFT = 0x21;

        public const ushort HID_USAGE_GAME_PITCH_FORWARD_BACK = 0x22;

        public const ushort HID_USAGE_GAME_ROLL_RIGHT_LEFT = 0x23;

        public const ushort HID_USAGE_GAME_MOVE_RIGHT_LEFT = 0x24;

        public const ushort HID_USAGE_GAME_MOVE_FORWARD_BACK = 0x25;

        public const ushort HID_USAGE_GAME_MOVE_UP_DOWN = 0x26;

        public const ushort HID_USAGE_GAME_LEAN_RIGHT_LEFT = 0x27;

        public const ushort HID_USAGE_GAME_LEAN_FORWARD_BACK = 0x28;

        public const ushort HID_USAGE_GAME_POV_HEIGHT = 0x29;

        public const ushort HID_USAGE_GAME_FLIPPER = 0x2A;

        public const ushort HID_USAGE_GAME_SECONDARY_FLIPPER = 0x2B;

        public const ushort HID_USAGE_GAME_BUMP = 0x2C;

        public const ushort HID_USAGE_GAME_NEW_GAME = 0x2D;

        public const ushort HID_USAGE_GAME_SHOOT_BALL = 0x2E;

        public const ushort HID_USAGE_GAME_PLAYER = 0x2F;

        public const ushort HID_USAGE_GAME_GUN_BOLT = 0x30;

        public const ushort HID_USAGE_GAME_GUN_CLIP = 0x31;

        public const ushort HID_USAGE_GAME_GUN_SINGLE_SHOT = 0x33;

        public const ushort HID_USAGE_GAME_GUN_BURST = 0x34;

        public const ushort HID_USAGE_GAME_GUN_AUTOMATIC = 0x35;

        public const ushort HID_USAGE_GAME_GUN_SAFETY = 0x36;

        public const ushort HID_USAGE_GENERIC_DEVICE_BATTERY_STRENGTH = 0x20;

        public const ushort HID_USAGE_GENERIC_DEVICE_WIRELESS_CHANNEL = 0x21;

        public const ushort HID_USAGE_GENERIC_DEVICE_WIRELESS_ID = 0x22;

        public const ushort HID_USAGE_GENERIC_DEVICE_DISCOVER_WIRELESS_CONTROL = 0x23;

        public const ushort HID_USAGE_GENERIC_DEVICE_SECURITY_CODE_CHAR_ENTERED = 0x24;

        public const ushort HID_USAGE_GENERIC_DEVICE_SECURITY_CODE_CHAR_ERASED = 0x25;

        public const ushort HID_USAGE_GENERIC_DEVICE_SECURITY_CODE_CLEARED = 0x26;

        public const ushort HID_USAGE_KEYBOARD_NOEVENT = 0x00;

        public const ushort HID_USAGE_KEYBOARD_ROLLOVER = 0x01;

        public const ushort HID_USAGE_KEYBOARD_POSTFAIL = 0x02;

        public const ushort HID_USAGE_KEYBOARD_UNDEFINED = 0x03;

        public const ushort HID_USAGE_KEYBOARD_aA = 0x04;

        public const ushort HID_USAGE_KEYBOARD_zZ = 0x1D;

        public const ushort HID_USAGE_KEYBOARD_ONE = 0x1E;

        public const ushort HID_USAGE_KEYBOARD_ZERO = 0x27;

        public const ushort HID_USAGE_KEYBOARD_LCTRL = 0xE0;

        public const ushort HID_USAGE_KEYBOARD_LSHFT = 0xE1;

        public const ushort HID_USAGE_KEYBOARD_LALT = 0xE2;

        public const ushort HID_USAGE_KEYBOARD_LGUI = 0xE3;

        public const ushort HID_USAGE_KEYBOARD_RCTRL = 0xE4;

        public const ushort HID_USAGE_KEYBOARD_RSHFT = 0xE5;

        public const ushort HID_USAGE_KEYBOARD_RALT = 0xE6;

        public const ushort HID_USAGE_KEYBOARD_RGUI = 0xE7;

        public const ushort HID_USAGE_KEYBOARD_SCROLL_LOCK = 0x47;

        public const ushort HID_USAGE_KEYBOARD_NUM_LOCK = 0x53;

        public const ushort HID_USAGE_KEYBOARD_CAPS_LOCK = 0x39;

        public const ushort HID_USAGE_KEYBOARD_F1 = 0x3A;

        public const ushort HID_USAGE_KEYBOARD_F2 = 0x3B;

        public const ushort HID_USAGE_KEYBOARD_F3 = 0x3C;

        public const ushort HID_USAGE_KEYBOARD_F4 = 0x3D;

        public const ushort HID_USAGE_KEYBOARD_F5 = 0x3E;

        public const ushort HID_USAGE_KEYBOARD_F6 = 0x3F;

        public const ushort HID_USAGE_KEYBOARD_F7 = 0x40;

        public const ushort HID_USAGE_KEYBOARD_F8 = 0x41;

        public const ushort HID_USAGE_KEYBOARD_F9 = 0x42;

        public const ushort HID_USAGE_KEYBOARD_F10 = 0x43;

        public const ushort HID_USAGE_KEYBOARD_F11 = 0x44;

        public const ushort HID_USAGE_KEYBOARD_F12 = 0x45;

        public const ushort HID_USAGE_KEYBOARD_F13 = 0x68;

        public const ushort HID_USAGE_KEYBOARD_F14 = 0x69;

        public const ushort HID_USAGE_KEYBOARD_F15 = 0x6A;

        public const ushort HID_USAGE_KEYBOARD_F16 = 0x6B;

        public const ushort HID_USAGE_KEYBOARD_F17 = 0x6C;

        public const ushort HID_USAGE_KEYBOARD_F18 = 0x6D;

        public const ushort HID_USAGE_KEYBOARD_F19 = 0x6E;

        public const ushort HID_USAGE_KEYBOARD_F20 = 0x6F;

        public const ushort HID_USAGE_KEYBOARD_F21 = 0x70;

        public const ushort HID_USAGE_KEYBOARD_F22 = 0x71;

        public const ushort HID_USAGE_KEYBOARD_F23 = 0x72;

        public const ushort HID_USAGE_KEYBOARD_F24 = 0x73;

        public const ushort HID_USAGE_KEYBOARD_RETURN = 0x28;

        public const ushort HID_USAGE_KEYBOARD_ESCAPE = 0x29;

        public const ushort HID_USAGE_KEYBOARD_DELETE = 0x2A;

        public const ushort HID_USAGE_KEYBOARD_PRINT_SCREEN = 0x46;

        public const ushort HID_USAGE_KEYBOARD_DELETE_FORWARD = 0x4C;

        public const ushort HID_USAGE_LED_NUM_LOCK = 0x01;

        public const ushort HID_USAGE_LED_CAPS_LOCK = 0x02;

        public const ushort HID_USAGE_LED_SCROLL_LOCK = 0x03;

        public const ushort HID_USAGE_LED_COMPOSE = 0x04;

        public const ushort HID_USAGE_LED_KANA = 0x05;

        public const ushort HID_USAGE_LED_POWER = 0x06;

        public const ushort HID_USAGE_LED_SHIFT = 0x07;

        public const ushort HID_USAGE_LED_DO_NOT_DISTURB = 0x08;

        public const ushort HID_USAGE_LED_MUTE = 0x09;

        public const ushort HID_USAGE_LED_TONE_ENABLE = 0x0A;

        public const ushort HID_USAGE_LED_HIGH_CUT_FILTER = 0x0B;

        public const ushort HID_USAGE_LED_LOW_CUT_FILTER = 0x0C;

        public const ushort HID_USAGE_LED_EQUALIZER_ENABLE = 0x0D;

        public const ushort HID_USAGE_LED_SOUND_FIELD_ON = 0x0E;

        public const ushort HID_USAGE_LED_SURROUND_FIELD_ON = 0x0F;

        public const ushort HID_USAGE_LED_REPEAT = 0x10;

        public const ushort HID_USAGE_LED_STEREO = 0x11;

        public const ushort HID_USAGE_LED_SAMPLING_RATE_DETECT = 0x12;

        public const ushort HID_USAGE_LED_SPINNING = 0x13;

        public const ushort HID_USAGE_LED_CAV = 0x14;

        public const ushort HID_USAGE_LED_CLV = 0x15;

        public const ushort HID_USAGE_LED_RECORDING_FORMAT_DET = 0x16;

        public const ushort HID_USAGE_LED_OFF_HOOK = 0x17;

        public const ushort HID_USAGE_LED_RING = 0x18;

        public const ushort HID_USAGE_LED_MESSAGE_WAITING = 0x19;

        public const ushort HID_USAGE_LED_DATA_MODE = 0x1A;

        public const ushort HID_USAGE_LED_BATTERY_OPERATION = 0x1B;

        public const ushort HID_USAGE_LED_BATTERY_OK = 0x1C;

        public const ushort HID_USAGE_LED_BATTERY_LOW = 0x1D;

        public const ushort HID_USAGE_LED_SPEAKER = 0x1E;

        public const ushort HID_USAGE_LED_HEAD_SET = 0x1F;

        public const ushort HID_USAGE_LED_HOLD = 0x20;

        public const ushort HID_USAGE_LED_MICROPHONE = 0x21;

        public const ushort HID_USAGE_LED_COVERAGE = 0x22;

        public const ushort HID_USAGE_LED_NIGHT_MODE = 0x23;

        public const ushort HID_USAGE_LED_SEND_CALLS = 0x24;

        public const ushort HID_USAGE_LED_CALL_PICKUP = 0x25;

        public const ushort HID_USAGE_LED_CONFERENCE = 0x26;

        public const ushort HID_USAGE_LED_STAND_BY = 0x27;

        public const ushort HID_USAGE_LED_CAMERA_ON = 0x28;

        public const ushort HID_USAGE_LED_CAMERA_OFF = 0x29;

        public const ushort HID_USAGE_LED_ON_LINE = 0x2A;

        public const ushort HID_USAGE_LED_OFF_LINE = 0x2B;

        public const ushort HID_USAGE_LED_BUSY = 0x2C;

        public const ushort HID_USAGE_LED_READY = 0x2D;

        public const ushort HID_USAGE_LED_PAPER_OUT = 0x2E;

        public const ushort HID_USAGE_LED_PAPER_JAM = 0x2F;

        public const ushort HID_USAGE_LED_REMOTE = 0x30;

        public const ushort HID_USAGE_LED_FORWARD = 0x31;

        public const ushort HID_USAGE_LED_REVERSE = 0x32;

        public const ushort HID_USAGE_LED_STOP = 0x33;

        public const ushort HID_USAGE_LED_REWIND = 0x34;

        public const ushort HID_USAGE_LED_FAST_FORWARD = 0x35;

        public const ushort HID_USAGE_LED_PLAY = 0x36;

        public const ushort HID_USAGE_LED_PAUSE = 0x37;

        public const ushort HID_USAGE_LED_RECORD = 0x38;

        public const ushort HID_USAGE_LED_ERROR = 0x39;

        public const ushort HID_USAGE_LED_SELECTED_INDICATOR = 0x3A;

        public const ushort HID_USAGE_LED_IN_USE_INDICATOR = 0x3B;

        public const ushort HID_USAGE_LED_MULTI_MODE_INDICATOR = 0x3C;

        public const ushort HID_USAGE_LED_INDICATOR_ON = 0x3D;

        public const ushort HID_USAGE_LED_INDICATOR_FLASH = 0x3E;

        public const ushort HID_USAGE_LED_INDICATOR_SLOW_BLINK = 0x3F;

        public const ushort HID_USAGE_LED_INDICATOR_FAST_BLINK = 0x40;

        public const ushort HID_USAGE_LED_INDICATOR_OFF = 0x41;

        public const ushort HID_USAGE_LED_FLASH_ON_TIME = 0x42;

        public const ushort HID_USAGE_LED_SLOW_BLINK_ON_TIME = 0x43;

        public const ushort HID_USAGE_LED_SLOW_BLINK_OFF_TIME = 0x44;

        public const ushort HID_USAGE_LED_FAST_BLINK_ON_TIME = 0x45;

        public const ushort HID_USAGE_LED_FAST_BLINK_OFF_TIME = 0x46;

        public const ushort HID_USAGE_LED_INDICATOR_COLOR = 0x47;

        public const ushort HID_USAGE_LED_RED = 0x48;

        public const ushort HID_USAGE_LED_GREEN = 0x49;

        public const ushort HID_USAGE_LED_AMBER = 0x4A;

        public const ushort HID_USAGE_LED_GENERIC_INDICATOR = 0x4B;

        public const ushort HID_USAGE_LED_SYSTEM_SUSPEND = 0x4C;

        public const ushort HID_USAGE_LED_EXTERNAL_POWER = 0x4D;

        public const ushort HID_USAGE_TELEPHONY_PHONE = 0x01;

        public const ushort HID_USAGE_TELEPHONY_ANSWERING_MACHINE = 0x02;

        public const ushort HID_USAGE_TELEPHONY_MESSAGE_CONTROLS = 0x03;

        public const ushort HID_USAGE_TELEPHONY_HANDSET = 0x04;

        public const ushort HID_USAGE_TELEPHONY_HEADSET = 0x05;

        public const ushort HID_USAGE_TELEPHONY_KEYPAD = 0x06;

        public const ushort HID_USAGE_TELEPHONY_PROGRAMMABLE_BUTTON = 0x07;

        public const ushort HID_USAGE_TELEPHONY_REDIAL = 0x24;

        public const ushort HID_USAGE_TELEPHONY_TRANSFER = 0x25;

        public const ushort HID_USAGE_TELEPHONY_DROP = 0x26;

        public const ushort HID_USAGE_TELEPHONY_LINE = 0x2A;

        public const ushort HID_USAGE_TELEPHONY_RING_ENABLE = 0x2D;

        public const ushort HID_USAGE_TELEPHONY_SEND = 0x31;

        public const ushort HID_USAGE_TELEPHONY_KEYPAD_0 = 0xB0;

        public const ushort HID_USAGE_TELEPHONY_KEYPAD_D = 0xBF;

        public const ushort HID_USAGE_TELEPHONY_HOST_AVAILABLE = 0xF1;

        public const ushort HID_USAGE_CONSUMERCTRL = 0x01;

        public const ushort HID_USAGE_CONSUMER_CHANNEL_INCREMENT = 0x9C;

        public const ushort HID_USAGE_CONSUMER_CHANNEL_DECREMENT = 0x9D;

        public const ushort HID_USAGE_CONSUMER_PLAY = 0xB0;

        public const ushort HID_USAGE_CONSUMER_PAUSE = 0xB1;

        public const ushort HID_USAGE_CONSUMER_RECORD = 0xB2;

        public const ushort HID_USAGE_CONSUMER_FAST_FORWARD = 0xB3;

        public const ushort HID_USAGE_CONSUMER_REWIND = 0xB4;

        public const ushort HID_USAGE_CONSUMER_SCAN_NEXT_TRACK = 0xB5;

        public const ushort HID_USAGE_CONSUMER_SCAN_PREV_TRACK = 0xB6;

        public const ushort HID_USAGE_CONSUMER_STOP = 0xB7;

        public const ushort HID_USAGE_CONSUMER_PLAY_PAUSE = 0xCD;

        public const ushort HID_USAGE_CONSUMER_GAMEDVR_OPEN_GAMEBAR = 0xD0;

        public const ushort HID_USAGE_CONSUMER_GAMEDVR_TOGGLE_RECORD = 0xD1;

        public const ushort HID_USAGE_CONSUMER_GAMEDVR_RECORD_CLIP = 0xD2;

        public const ushort HID_USAGE_CONSUMER_GAMEDVR_SCREENSHOT = 0xD3;

        public const ushort HID_USAGE_CONSUMER_GAMEDVR_TOGGLE_INDICATOR = 0xD4;

        public const ushort HID_USAGE_CONSUMER_GAMEDVR_TOGGLE_MICROPHONE = 0xD5;

        public const ushort HID_USAGE_CONSUMER_GAMEDVR_TOGGLE_CAMERA = 0xD6;

        public const ushort HID_USAGE_CONSUMER_GAMEDVR_TOGGLE_BROADCAST = 0xD7;

        public const ushort HID_USAGE_CONSUMER_VOLUME = 0xE0;

        public const ushort HID_USAGE_CONSUMER_BALANCE = 0xE1;

        public const ushort HID_USAGE_CONSUMER_MUTE = 0xE2;

        public const ushort HID_USAGE_CONSUMER_BASS = 0xE3;

        public const ushort HID_USAGE_CONSUMER_TREBLE = 0xE4;

        public const ushort HID_USAGE_CONSUMER_BASS_BOOST = 0xE5;

        public const ushort HID_USAGE_CONSUMER_SURROUND_MODE = 0xE6;

        public const ushort HID_USAGE_CONSUMER_LOUDNESS = 0xE7;

        public const ushort HID_USAGE_CONSUMER_MPX = 0xE8;

        public const ushort HID_USAGE_CONSUMER_VOLUME_INCREMENT = 0xE9;

        public const ushort HID_USAGE_CONSUMER_VOLUME_DECREMENT = 0xEA;

        public const ushort HID_USAGE_CONSUMER_BASS_INCREMENT = 0x152;

        public const ushort HID_USAGE_CONSUMER_BASS_DECREMENT = 0x153;

        public const ushort HID_USAGE_CONSUMER_TREBLE_INCREMENT = 0x154;

        public const ushort HID_USAGE_CONSUMER_TREBLE_DECREMENT = 0x155;

        public const ushort HID_USAGE_CONSUMER_AL_CONFIGURATION = 0x183;

        public const ushort HID_USAGE_CONSUMER_AL_EMAIL = 0x18A;

        public const ushort HID_USAGE_CONSUMER_AL_CALCULATOR = 0x192;

        public const ushort HID_USAGE_CONSUMER_AL_BROWSER = 0x194;

        public const ushort HID_USAGE_CONSUMER_AL_SEARCH = 0x1C6;

        public const ushort HID_USAGE_CONSUMER_AC_SEARCH = 0x221;

        public const ushort HID_USAGE_CONSUMER_AC_GOTO = 0x222;

        public const ushort HID_USAGE_CONSUMER_AC_HOME = 0x223;

        public const ushort HID_USAGE_CONSUMER_AC_BACK = 0x224;

        public const ushort HID_USAGE_CONSUMER_AC_FORWARD = 0x225;

        public const ushort HID_USAGE_CONSUMER_AC_STOP = 0x226;

        public const ushort HID_USAGE_CONSUMER_AC_REFRESH = 0x227;

        public const ushort HID_USAGE_CONSUMER_AC_PREVIOUS = 0x228;

        public const ushort HID_USAGE_CONSUMER_AC_NEXT = 0x229;

        public const ushort HID_USAGE_CONSUMER_AC_BOOKMARKS = 0x22A;

        public const ushort HID_USAGE_CONSUMER_AC_PAN = 0x238;

        public const ushort HID_USAGE_CONSUMER_EXTENDED_KEYBOARD_ATTRIBUTES_COLLECTION = 0x2C0;

        public const ushort HID_USAGE_CONSUMER_KEYBOARD_FORM_FACTOR = 0x2C1;

        public const ushort HID_USAGE_CONSUMER_KEYBOARD_KEY_TYPE = 0x2C2;

        public const ushort HID_USAGE_CONSUMER_KEYBOARD_PHYSICAL_LAYOUT = 0x2C3;

        public const ushort HID_USAGE_CONSUMER_VENDOR_SPECIFIC_KEYBOARD_PHYSICAL_LAYOUT = 0x2C4;

        public const ushort HID_USAGE_CONSUMER_KEYBOARD_IETF_LANGUAGE_TAG_INDEX = 0x2C5;

        public const ushort HID_USAGE_CONSUMER_IMPLEMENTED_KEYBOARD_INPUT_ASSIST_CONTROLS = 0x2C6;

        public const ushort HID_USAGE_DIGITIZER_DIGITIZER = 0x01;

        public const ushort HID_USAGE_DIGITIZER_PEN = 0x02;

        public const ushort HID_USAGE_DIGITIZER_LIGHT_PEN = 0x03;

        public const ushort HID_USAGE_DIGITIZER_TOUCH_SCREEN = 0x04;

        public const ushort HID_USAGE_DIGITIZER_TOUCH_PAD = 0x05;

        public const ushort HID_USAGE_DIGITIZER_WHITE_BOARD = 0x06;

        public const ushort HID_USAGE_DIGITIZER_COORD_MEASURING = 0x07;

        public const ushort HID_USAGE_DIGITIZER_3D_DIGITIZER = 0x08;

        public const ushort HID_USAGE_DIGITIZER_STEREO_PLOTTER = 0x09;

        public const ushort HID_USAGE_DIGITIZER_ARTICULATED_ARM = 0x0A;

        public const ushort HID_USAGE_DIGITIZER_ARMATURE = 0x0B;

        public const ushort HID_USAGE_DIGITIZER_MULTI_POINT = 0x0C;

        public const ushort HID_USAGE_DIGITIZER_FREE_SPACE_WAND = 0x0D;

        public const ushort HID_USAGE_DIGITIZER_STYLUS = 0x20;

        public const ushort HID_USAGE_DIGITIZER_PUCK = 0x21;

        public const ushort HID_USAGE_DIGITIZER_FINGER = 0x22;

        public const ushort HID_USAGE_DIGITIZER_TABLET_FUNC_KEYS = 0x39;

        public const ushort HID_USAGE_DIGITIZER_PROG_CHANGE_KEYS = 0x3A;

        public const ushort HID_USAGE_DIGITIZER_TIP_PRESSURE = 0x30;

        public const ushort HID_USAGE_DIGITIZER_BARREL_PRESSURE = 0x31;

        public const ushort HID_USAGE_DIGITIZER_IN_RANGE = 0x32;

        public const ushort HID_USAGE_DIGITIZER_TOUCH = 0x33;

        public const ushort HID_USAGE_DIGITIZER_UNTOUCH = 0x34;

        public const ushort HID_USAGE_DIGITIZER_TAP = 0x35;

        public const ushort HID_USAGE_DIGITIZER_QUALITY = 0x36;

        public const ushort HID_USAGE_DIGITIZER_DATA_VALID = 0x37;

        public const ushort HID_USAGE_DIGITIZER_TRANSDUCER_INDEX = 0x38;

        public const ushort HID_USAGE_DIGITIZER_BATTERY_STRENGTH = 0x3B;

        public const ushort HID_USAGE_DIGITIZER_INVERT = 0x3C;

        public const ushort HID_USAGE_DIGITIZER_X_TILT = 0x3D;

        public const ushort HID_USAGE_DIGITIZER_Y_TILT = 0x3E;

        public const ushort HID_USAGE_DIGITIZER_AZIMUTH = 0x3F;

        public const ushort HID_USAGE_DIGITIZER_ALTITUDE = 0x40;

        public const ushort HID_USAGE_DIGITIZER_TWIST = 0x41;

        public const ushort HID_USAGE_DIGITIZER_TIP_SWITCH = 0x42;

        public const ushort HID_USAGE_DIGITIZER_SECONDARY_TIP_SWITCH = 0x43;

        public const ushort HID_USAGE_DIGITIZER_BARREL_SWITCH = 0x44;

        public const ushort HID_USAGE_DIGITIZER_ERASER = 0x45;

        public const ushort HID_USAGE_DIGITIZER_TABLET_PICK = 0x46;

        public const ushort HID_USAGE_DIGITIZER_TRANSDUCER_SERIAL = 0x5B;

        public const ushort HID_USAGE_DIGITIZER_TRANSDUCER_VENDOR = 0x92;

        public const ushort HID_USAGE_DIGITIZER_TRANSDUCER_CONNECTED = 0xA2;

        public const ushort HID_USAGE_HAPTICS_SIMPLE_CONTROLLER = 0x01;

        public const ushort HID_USAGE_HAPTICS_WAVEFORM_LIST = 0x10;

        public const ushort HID_USAGE_HAPTICS_DURATION_LIST = 0x11;

        public const ushort HID_USAGE_HAPTICS_AUTO_TRIGGER = 0x20;

        public const ushort HID_USAGE_HAPTICS_MANUAL_TRIGGER = 0x21;

        public const ushort HID_USAGE_HAPTICS_AUTO_ASSOCIATED_CONTROL = 0x22;

        public const ushort HID_USAGE_HAPTICS_INTENSITY = 0x23;

        public const ushort HID_USAGE_HAPTICS_REPEAT_COUNT = 0x24;

        public const ushort HID_USAGE_HAPTICS_RETRIGGER_PERIOD = 0x25;

        public const ushort HID_USAGE_HAPTICS_WAVEFORM_VENDOR_PAGE = 0x26;

        public const ushort HID_USAGE_HAPTICS_WAVEFORM_VENDOR_ID = 0x27;

        public const ushort HID_USAGE_HAPTICS_WAVEFORM_CUTOFF_TIME = 0x28;

        public const ushort HID_USAGE_HAPTICS_WAVEFORM_BEGIN = 0x1000;

        public const ushort HID_USAGE_HAPTICS_WAVEFORM_STOP = 0x1001;

        public const ushort HID_USAGE_HAPTICS_WAVEFORM_NULL = 0x1002;

        public const ushort HID_USAGE_HAPTICS_WAVEFORM_CLICK = 0x1003;

        public const ushort HID_USAGE_HAPTICS_WAVEFORM_BUZZ = 0x1004;

        public const ushort HID_USAGE_HAPTICS_WAVEFORM_RUMBLE = 0x1005;

        public const ushort HID_USAGE_HAPTICS_WAVEFORM_PRESS = 0x1006;

        public const ushort HID_USAGE_HAPTICS_WAVEFORM_RELEASE = 0x1007;

        public const ushort HID_USAGE_HAPTICS_WAVEFORM_END = 0x1FFF;

        public const ushort HID_USAGE_HAPTICS_WAVEFORM_VENDOR_BEGIN = 0x2000;

        public const ushort HID_USAGE_HAPTICS_WAVEFORM_VENDOR_END = 0x2FFF;

        public const ushort HID_USAGE_ALPHANUMERIC_ALPHANUMERIC_DISPLAY = 0x01;

        public const ushort HID_USAGE_ALPHANUMERIC_BITMAPPED_DISPLAY = 0x02;

        public const ushort HID_USAGE_ALPHANUMERIC_DISPLAY_ATTRIBUTES_REPORT = 0x20;

        public const ushort HID_USAGE_ALPHANUMERIC_DISPLAY_CONTROL_REPORT = 0x24;

        public const ushort HID_USAGE_ALPHANUMERIC_CHARACTER_REPORT = 0x2B;

        public const ushort HID_USAGE_ALPHANUMERIC_DISPLAY_STATUS = 0x2D;

        public const ushort HID_USAGE_ALPHANUMERIC_CURSOR_POSITION_REPORT = 0x32;

        public const ushort HID_USAGE_ALPHANUMERIC_FONT_REPORT = 0x3B;

        public const ushort HID_USAGE_ALPHANUMERIC_FONT_DATA = 0x3C;

        public const ushort HID_USAGE_ALPHANUMERIC_CHARACTER_ATTRIBUTE = 0x48;

        public const ushort HID_USAGE_ALPHANUMERIC_PALETTE_REPORT = 0x85;

        public const ushort HID_USAGE_ALPHANUMERIC_PALETTE_DATA = 0x88;

        public const ushort HID_USAGE_ALPHANUMERIC_BLIT_REPORT = 0x8A;

        public const ushort HID_USAGE_ALPHANUMERIC_BLIT_DATA = 0x8F;

        public const ushort HID_USAGE_ALPHANUMERIC_SOFT_BUTTON = 0x90;

        public const ushort HID_USAGE_ALPHANUMERIC_ASCII_CHARACTER_SET = 0x21;

        public const ushort HID_USAGE_ALPHANUMERIC_DATA_READ_BACK = 0x22;

        public const ushort HID_USAGE_ALPHANUMERIC_FONT_READ_BACK = 0x23;

        public const ushort HID_USAGE_ALPHANUMERIC_CLEAR_DISPLAY = 0x25;

        public const ushort HID_USAGE_ALPHANUMERIC_DISPLAY_ENABLE = 0x26;

        public const ushort HID_USAGE_ALPHANUMERIC_SCREEN_SAVER_DELAY = 0x27;

        public const ushort HID_USAGE_ALPHANUMERIC_SCREEN_SAVER_ENABLE = 0x28;

        public const ushort HID_USAGE_ALPHANUMERIC_VERTICAL_SCROLL = 0x29;

        public const ushort HID_USAGE_ALPHANUMERIC_HORIZONTAL_SCROLL = 0x2A;

        public const ushort HID_USAGE_ALPHANUMERIC_DISPLAY_DATA = 0x2C;

        public const ushort HID_USAGE_ALPHANUMERIC_STATUS_NOT_READY = 0x2E;

        public const ushort HID_USAGE_ALPHANUMERIC_STATUS_READY = 0x2F;

        public const ushort HID_USAGE_ALPHANUMERIC_ERR_NOT_A_LOADABLE_CHARACTER = 0x30;

        public const ushort HID_USAGE_ALPHANUMERIC_ERR_FONT_DATA_CANNOT_BE_READ = 0x31;

        public const ushort HID_USAGE_ALPHANUMERIC_ROW = 0x33;

        public const ushort HID_USAGE_ALPHANUMERIC_COLUMN = 0x34;

        public const ushort HID_USAGE_ALPHANUMERIC_ROWS = 0x35;

        public const ushort HID_USAGE_ALPHANUMERIC_COLUMNS = 0x36;

        public const ushort HID_USAGE_ALPHANUMERIC_CURSOR_PIXEL_POSITIONING = 0x37;

        public const ushort HID_USAGE_ALPHANUMERIC_CURSOR_MODE = 0x38;

        public const ushort HID_USAGE_ALPHANUMERIC_CURSOR_ENABLE = 0x39;

        public const ushort HID_USAGE_ALPHANUMERIC_CURSOR_BLINK = 0x3A;

        public const ushort HID_USAGE_ALPHANUMERIC_CHAR_WIDTH = 0x3D;

        public const ushort HID_USAGE_ALPHANUMERIC_CHAR_HEIGHT = 0x3E;

        public const ushort HID_USAGE_ALPHANUMERIC_CHAR_SPACING_HORIZONTAL = 0x3F;

        public const ushort HID_USAGE_ALPHANUMERIC_CHAR_SPACING_VERTICAL = 0x40;

        public const ushort HID_USAGE_ALPHANUMERIC_UNICODE_CHAR_SET = 0x41;

        public const ushort HID_USAGE_ALPHANUMERIC_FONT_7_SEGMENT = 0x42;

        public const ushort HID_USAGE_ALPHANUMERIC_7_SEGMENT_DIRECT_MAP = 0x43;

        public const ushort HID_USAGE_ALPHANUMERIC_FONT_14_SEGMENT = 0x44;

        public const ushort HID_USAGE_ALPHANUMERIC_14_SEGMENT_DIRECT_MAP = 0x45;

        public const ushort HID_USAGE_ALPHANUMERIC_DISPLAY_BRIGHTNESS = 0x46;

        public const ushort HID_USAGE_ALPHANUMERIC_DISPLAY_CONTRAST = 0x47;

        public const ushort HID_USAGE_ALPHANUMERIC_ATTRIBUTE_READBACK = 0x49;

        public const ushort HID_USAGE_ALPHANUMERIC_ATTRIBUTE_DATA = 0x4A;

        public const ushort HID_USAGE_ALPHANUMERIC_CHAR_ATTR_ENHANCE = 0x4B;

        public const ushort HID_USAGE_ALPHANUMERIC_CHAR_ATTR_UNDERLINE = 0x4C;

        public const ushort HID_USAGE_ALPHANUMERIC_CHAR_ATTR_BLINK = 0x4D;

        public const ushort HID_USAGE_ALPHANUMERIC_BITMAP_SIZE_X = 0x80;

        public const ushort HID_USAGE_ALPHANUMERIC_BITMAP_SIZE_Y = 0x81;

        public const ushort HID_USAGE_ALPHANUMERIC_BIT_DEPTH_FORMAT = 0x83;

        public const ushort HID_USAGE_ALPHANUMERIC_DISPLAY_ORIENTATION = 0x84;

        public const ushort HID_USAGE_ALPHANUMERIC_PALETTE_DATA_SIZE = 0x86;

        public const ushort HID_USAGE_ALPHANUMERIC_PALETTE_DATA_OFFSET = 0x87;

        public const ushort HID_USAGE_ALPHANUMERIC_BLIT_RECTANGLE_X1 = 0x8B;

        public const ushort HID_USAGE_ALPHANUMERIC_BLIT_RECTANGLE_Y1 = 0x8C;

        public const ushort HID_USAGE_ALPHANUMERIC_BLIT_RECTANGLE_X2 = 0x8D;

        public const ushort HID_USAGE_ALPHANUMERIC_BLIT_RECTANGLE_Y2 = 0x8E;

        public const ushort HID_USAGE_ALPHANUMERIC_SOFT_BUTTON_ID = 0x91;

        public const ushort HID_USAGE_ALPHANUMERIC_SOFT_BUTTON_SIDE = 0x92;

        public const ushort HID_USAGE_ALPHANUMERIC_SOFT_BUTTON_OFFSET1 = 0x93;

        public const ushort HID_USAGE_ALPHANUMERIC_SOFT_BUTTON_OFFSET2 = 0x94;

        public const ushort HID_USAGE_ALPHANUMERIC_SOFT_BUTTON_REPORT = 0x95;

        public const ushort HID_USAGE_LAMPARRAY = 0x01;

        public const ushort HID_USAGE_LAMPARRAY_ATTRBIUTES_REPORT = 0x02;

        public const ushort HID_USAGE_LAMPARRAY_LAMP_COUNT = 0x03;

        public const ushort HID_USAGE_LAMPARRAY_BOUNDING_BOX_WIDTH_IN_MICROMETERS = 0x04;

        public const ushort HID_USAGE_LAMPARRAY_BOUNDING_BOX_HEIGHT_IN_MICROMETERS = 0x05;

        public const ushort HID_USAGE_LAMPARRAY_BOUNDING_BOX_DEPTH_IN_MICROMETERS = 0x06;

        public const ushort HID_USAGE_LAMPARRAY_KIND = 0x07;

        public const ushort HID_USAGE_LAMPARRAY_MIN_UPDATE_INTERVAL_IN_MICROSECONDS = 0x08;

        public const ushort HID_USAGE_LAMPARRAY_LAMP_ATTRIBUTES_REQUEST_REPORT = 0x20;

        public const ushort HID_USAGE_LAMPARRAY_LAMP_ID = 0x21;

        public const ushort HID_USAGE_LAMPARRAY_LAMP_ATTRIBUTES_RESPONSE_REPORT = 0x22;

        public const ushort HID_USAGE_LAMPARRAY_POSITION_X_IN_MICROMETERS = 0x23;

        public const ushort HID_USAGE_LAMPARRAY_POSITION_Y_IN_MICROMETERS = 0x24;

        public const ushort HID_USAGE_LAMPARRAY_POSITION_Z_IN_MICROMETERS = 0x25;

        public const ushort HID_USAGE_LAMPARRAY_LAMP_PURPOSES = 0x26;

        public const ushort HID_USAGE_LAMPARRAY_UPDATE_LATENCY_IN_MICROSECONDS = 0x27;

        public const ushort HID_USAGE_LAMPARRAY_RED_LEVEL_COUNT = 0x28;

        public const ushort HID_USAGE_LAMPARRAY_GREEN_LEVEL_COUNT = 0x29;

        public const ushort HID_USAGE_LAMPARRAY_BLUE_LEVEL_COUNT = 0x2A;

        public const ushort HID_USAGE_LAMPARRAY_INTENSITY_LEVEL_COUNT = 0x2B;

        public const ushort HID_USAGE_LAMPARRAY_IS_PROGRAMMABLE = 0x2C;

        public const ushort HID_USAGE_LAMPARRAY_INPUT_BINDING = 0x2D;

        public const ushort HID_USAGE_LAMPARRAY_LAMP_MULTI_UPDATE_REPORT = 0x50;

        public const ushort HID_USAGE_LAMPARRAY_LAMP_RED_UPDATE_CHANNEL = 0x51;

        public const ushort HID_USAGE_LAMPARRAY_LAMP_GREEN_UPDATE_CHANNEL = 0x52;

        public const ushort HID_USAGE_LAMPARRAY_LAMP_BLUE_UPDATE_CHANNEL = 0x53;

        public const ushort HID_USAGE_LAMPARRAY_LAMP_INTENSITY_UPDATE_CHANNEL = 0x54;

        public const ushort HID_USAGE_LAMPARRAY_LAMP_UPDATE_FLAGS = 0x55;

        public const ushort HID_USAGE_LAMPARRAY_LAMP_RANGE_UPDATE_REPORT = 0x60;

        public const ushort HID_USAGE_LAMPARRAY_LAMP_ID_START = 0x61;

        public const ushort HID_USAGE_LAMPARRAY_LAMP_ID_END = 0x62;

        public const ushort HID_USAGE_LAMPARRAY_CONTROL_REPORT = 0x70;

        public const ushort HID_USAGE_LAMPARRAY_AUTONOMOUS_MODE = 0x71;

        public const ushort HID_USAGE_CAMERA_AUTO_FOCUS = 0x20;

        public const ushort HID_USAGE_CAMERA_SHUTTER = 0x21;

        public const ushort HID_USAGE_MS_BTH_HF_DIALNUMBER = 0x21;

        public const ushort HID_USAGE_MS_BTH_HF_DIALMEMORY = 0x22;
    }
}