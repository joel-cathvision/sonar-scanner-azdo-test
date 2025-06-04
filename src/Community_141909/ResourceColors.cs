using System.Diagnostics.CodeAnalysis;
using System.Windows.Media;

namespace CathVision.Cube.Recorder.WpfUtilities
{
    /// <summary>
    ///     When adding new colors use the following URL to get a name:
    ///     https://colors.artyclick.com/color-name-finder/
    ///     Sorted in numerical order
    /// </summary>
    [ExcludeFromCodeCoverage(Justification = "Just a color dictionary")]
    public static class ResourceColors
    {
        public static readonly Color Transparent = Color.FromArgb(0x00, 0x00, 0x00, 0x00);
        public static readonly Color Black = Color.FromRgb(0x00, 0x00, 0x00);        //#000000
        public static readonly Color GreenHaze = Color.FromRgb(0x00, 0xb6, 0x3c);        //#00b63c (ButterscotchTwo but green)
        public static readonly Color HighContrastGreen = Color.FromRgb(0x07, 0xe8, 0x03);        //#07E803
        public static readonly Color BattleshipGrey = Color.FromRgb(0x6e, 0x7f, 0x7c);        //#6e7f7c
        public static readonly Color Silver = Color.FromRgb(0xB7, 0xBF, 0xBE);        //#b7bfbe
        public static readonly Color ClockGreyDark = Color.FromRgb(0xba, 0xba, 0xba);        //#bababa
        public static readonly Color Ice = Color.FromRgb(0xea, 0xf0, 0xef);        //#eaf0ef
        public static readonly Color IceHover = Color.FromRgb(0xCB, 0xDA, 0xD8);        //##CBDAD8
        public static readonly Color IceWith20Transparency = Color.FromArgb(0xCC, 0xea, 0xf0, 0xef); //#e6eaf0ef
        public static readonly Color RecordRed = Color.FromRgb(0xff, 0x3c, 0x46);        //#ff3c46
        public static readonly Color HighContrastRed = Color.FromRgb(0xff, 0x0f, 0x1b);        //#FF0F1B
        public static readonly Color ButterscotchTwo = Color.FromRgb(0xff, 0xb6, 0x3c);        //#ffb63c
        public static readonly Color White = Color.FromRgb(0xff, 0xff, 0xff);        //#ffffff
        public static readonly Color WarningYellow = Color.FromRgb(0xf3, 0xc8, 0x36);        //#f3c836
        public static readonly Color HighContrastYellow = Color.FromRgb(0xff, 0xf5, 0x11);        //#FFF511
        public static readonly Color BackgroundGrey = Color.FromRgb(0x3A, 0x3A, 0x3A);        //#3A3A3A
        public static readonly Color TransparentBlack = Color.FromArgb(130, 0, 0, 0);
        public static readonly Color SemitransparentCoolGrey = Color.FromArgb(0x93, 0x9f, 0x9d, 128);

        public static readonly Color StopWatchPink = Color.FromRgb(216, 4, 148); //#80494
        public static readonly Color StopWatchPurple = Color.FromRgb(112, 84, 220); //#7054dc

        public static readonly Color PeacockBlueDark2 = Color.FromRgb(0x00, 0x3E, 0x4F); //#003E4F
        public static readonly Color PeacockBlueDark1 = Color.FromRgb(0x00, 0x53, 0x6A); //#00536A
        public static readonly Color PeacockBlue = Color.FromRgb(0x00, 0x68, 0x85); //#006885x
        public static readonly Color PeacockBlueLight1 = Color.FromRgb(0x33, 0x7A, 0x94); //#337A94
        public static readonly Color PeacockBlueLight2 = Color.FromRgb(0x66, 0x8D, 0xA3); //#668DA3
        public static readonly Color PeacockBlueLight4 = Color.FromRgb(0xe5, 0xef, 0xf2); //#e5eff2 (90% lighter version of PeacockBlue)

        public static readonly Color FlagBlue = Color.FromRgb(88, 255, 254); //#58FFFE

        public static readonly Color TealBlue = Color.FromRgb(0x00, 0x95, 0xa6); //#0095a6
        public static readonly Color TealBlueDark1 = Color.FromRgb(0x00, 0x4C, 0x55); //#004C55
        public static readonly Color TealBlueDark2 = Color.FromRgb(0x00, 0x39, 0x40); //#003940

        public static readonly Color TonedBlue = Color.FromRgb(0x10, 0x64, 0x76); //#106476
        public static readonly Color GreenBlue = Color.FromRgb(0x00, 0xab, 0xa0); //#00aba0
        public static readonly Color GreenBlueHover = Color.FromRgb(0x5d, 0xaa, 0x9B); //#5DAA9B
        public static readonly Color CathVisionLogoBlue = Color.FromRgb(0x09, 0x43, 0x5a); //#09435A
        public static readonly Color ScreenBg = Color.FromRgb(0x27, 0x27, 0x27); //#272727
        public static readonly Color ScreenBgAccent = Color.FromRgb(0x67, 0x67, 0x67); //#373737
        public static readonly Color DarkSkyBlueHover = Color.FromRgb(0x41, 0x8d, 0xc9); //#418dc9
        public static readonly Color DarkSkyBlue = Color.FromRgb(0x4d, 0xa7, 0xed); //#4da7ed (85% darker version of DarkSkyBlue)
        public static readonly Color CoolGrey = Color.FromRgb(0x93, 0x9f, 0x9d); //#939f9d
        public static readonly Color DarkSkyBlueLightHover = Color.FromRgb(0xca, 0xe5, 0xfa); //#cae5fa
        public static readonly Color ClockGrey = Color.FromRgb(0xcf, 0xcf, 0xcf); //#cfcfcf
        public static readonly Color PaleAqua = Color.FromRgb(0xd2, 0xde, 0xdb); //#d2dedb
        public static readonly Color PaleGrey = Color.FromRgb(0xf4, 0xf7, 0xf7); //#f4f7f7

        public static readonly Color CarolinaBlue = Color.FromRgb(0x59, 0xa4, 0xda); //#59a4da

        public static readonly SolidColorBrush BlackBrush = MakeBrush(Black);
        public static readonly SolidColorBrush PeacockBlueBrush = MakeBrush(PeacockBlue);
        public static readonly SolidColorBrush PeacockBlueLight2Brush = MakeBrush(PeacockBlueLight2);
        public static readonly SolidColorBrush PeacockBlueLight4Brush = MakeBrush(PeacockBlueLight4);
        public static readonly SolidColorBrush FlagBlueBrush = MakeBrush(FlagBlue);
        public static readonly SolidColorBrush TealBlueBrush = MakeBrush(TealBlue);
        public static readonly SolidColorBrush TonedBlueBrush = MakeBrush(TonedBlue);
        public static readonly SolidColorBrush GreenBlueBrush = MakeBrush(GreenBlue);
        public static readonly SolidColorBrush GreenBlueHoverBrush = MakeBrush(GreenBlueHover);
        public static readonly SolidColorBrush GreenHazeBrush = MakeBrush(GreenHaze);
        public static readonly SolidColorBrush HighContrastGreenBrush = MakeBrush(HighContrastGreen);
        public static readonly SolidColorBrush CathVisionLogoBlueBrush = MakeBrush(CathVisionLogoBlue);
        public static readonly SolidColorBrush ScreenBgBrush = MakeBrush(ScreenBg);
        public static readonly SolidColorBrush ScreenBgAccentBrush = MakeBrush(ScreenBgAccent);
        public static readonly SolidColorBrush DarkSkyBlueHoverBrush = MakeBrush(DarkSkyBlueHover);
        public static readonly SolidColorBrush DarkSkyBlueBrush = MakeBrush(DarkSkyBlue);
        public static readonly SolidColorBrush BattleshipGreyBrush = MakeBrush(BattleshipGrey);
        public static readonly SolidColorBrush CoolGreyBrush = MakeBrush(CoolGrey);
        public static readonly SolidColorBrush SilverBrush = MakeBrush(Silver);
        public static readonly SolidColorBrush ClockGreyDarkBrush = MakeBrush(ClockGreyDark);
        public static readonly SolidColorBrush DarkSkyBlueLightHoverBrush = MakeBrush(DarkSkyBlueLightHover);
        public static readonly SolidColorBrush ClockGreyBrush = MakeBrush(ClockGrey);
        public static readonly SolidColorBrush PaleAquaBrush = MakeBrush(PaleAqua);
        public static readonly SolidColorBrush IceBrush = MakeBrush(Ice);
        public static readonly SolidColorBrush IceHoverBrush = MakeBrush(IceHover);
        public static readonly SolidColorBrush PaleGreyBrush = MakeBrush(PaleGrey);
        public static readonly SolidColorBrush RecordRedBrush = MakeBrush(RecordRed);
        public static readonly SolidColorBrush HighContrastRedBrush = MakeBrush(HighContrastRed);
        public static readonly SolidColorBrush ButterscotchTwoBrush = MakeBrush(ButterscotchTwo);
        public static readonly SolidColorBrush WhiteBrush = MakeBrush(White);
        public static readonly SolidColorBrush WarningYellowBrush = MakeBrush(WarningYellow);
        public static readonly SolidColorBrush HighContrastYellowBrush = MakeBrush(HighContrastYellow);
        public static readonly SolidColorBrush BackgroundGreyBrush = MakeBrush(BackgroundGrey);
        public static readonly SolidColorBrush TransparentBrush = MakeBrush(Transparent);

        public static readonly SolidColorBrush StopWatchPinkBrush = MakeBrush(StopWatchPink);
        public static readonly SolidColorBrush StopWatchPurpleBrush = MakeBrush(StopWatchPurple);

        /// <summary>
        ///     Returns either white or black depending on (background) color given.
        /// </summary>
        /// <param name="backgroundColor">The background color.</param>
        /// <returns>Black or white.</returns>
        public static Color GetForegroundColor(Color backgroundColor) => ShouldBeBlack(backgroundColor) ? Black : White;

        /// <summary>
        ///     Returns either white or black depending on (background) color given.
        /// </summary>
        /// <param name="backgroundBrush">The background color.</param>
        /// <returns>Black or white.</returns>
        public static SolidColorBrush GetForegroundColor(SolidColorBrush backgroundBrush) => ShouldBeBlack(backgroundBrush.Color) ? BlackBrush : WhiteBrush;

        private static bool ShouldBeBlack(Color backgroundColor) => CalculateBrightness(backgroundColor) > 127;

        /// <summary>
        ///     https://www.nbdtech.com/Blog/archive/2008/04/27/Calculating-the-Perceived-Brightness-of-a-Color.aspx
        /// </summary>
        private static int CalculateBrightness(Color backgroundColor) =>
            (int)Math.Sqrt(
                backgroundColor.R * backgroundColor.R * .241 +
                backgroundColor.G * backgroundColor.G * .691 +
                backgroundColor.B * backgroundColor.B * .068);

        private static SolidColorBrush MakeBrush(Color color)
        {
            SolidColorBrush brush = new(color);
            brush.Freeze();
            return brush;
        }
    }
}