namespace Fonet.Render.Pdf.Fonts {
    internal class Courier : Base14Font {
        private static readonly int[] DefaultWidths;

        private static readonly CodePointMapping DefaultMapping
            = CodePointMapping.GetMapping("WinAnsiEncoding");

        public Courier()
            : base("Courier", "WinAnsiEncoding", 562, 629, -157, 32, 255, DefaultWidths, DefaultMapping) {}

        static Courier() {
            DefaultWidths = new int[256];
            DefaultWidths[0x0041] = 600;
            DefaultWidths[0x00C6] = 600;
            DefaultWidths[0x00C1] = 600;
            DefaultWidths[0x00C2] = 600;
            DefaultWidths[0x00C4] = 600;
            DefaultWidths[0x00C0] = 600;
            DefaultWidths[0x00C5] = 600;
            DefaultWidths[0x00C3] = 600;
            DefaultWidths[0x0042] = 600;
            DefaultWidths[0x0043] = 600;
            DefaultWidths[0x00C7] = 600;
            DefaultWidths[0x0044] = 600;
            DefaultWidths[0x0045] = 600;
            DefaultWidths[0x00C9] = 600;
            DefaultWidths[0x00CA] = 600;
            DefaultWidths[0x00CB] = 600;
            DefaultWidths[0x00C8] = 600;
            DefaultWidths[0x00D0] = 600;
            DefaultWidths[0x0080] = 600;
            DefaultWidths[0x0046] = 600;
            DefaultWidths[0x0047] = 600;
            DefaultWidths[0x0048] = 600;
            DefaultWidths[0x0049] = 600;
            DefaultWidths[0x00CD] = 600;
            DefaultWidths[0x00CE] = 600;
            DefaultWidths[0x00CF] = 600;
            DefaultWidths[0x00CC] = 600;
            DefaultWidths[0x004A] = 600;
            DefaultWidths[0x004B] = 600;
            DefaultWidths[0x004C] = 600;
            DefaultWidths[0x004D] = 600;
            DefaultWidths[0x004E] = 600;
            DefaultWidths[0x00D1] = 600;
            DefaultWidths[0x004F] = 600;
            DefaultWidths[0x008C] = 600;
            DefaultWidths[0x00D3] = 600;
            DefaultWidths[0x00D4] = 600;
            DefaultWidths[0x00D6] = 600;
            DefaultWidths[0x00D2] = 600;
            DefaultWidths[0x00D8] = 600;
            DefaultWidths[0x00D5] = 600;
            DefaultWidths[0x0050] = 600;
            DefaultWidths[0x0051] = 600;
            DefaultWidths[0x0052] = 600;
            DefaultWidths[0x0053] = 600;
            DefaultWidths[0x008A] = 600;
            DefaultWidths[0x0054] = 600;
            DefaultWidths[0x00DE] = 600;
            DefaultWidths[0x0055] = 600;
            DefaultWidths[0x00DA] = 600;
            DefaultWidths[0x00DB] = 600;
            DefaultWidths[0x00DC] = 600;
            DefaultWidths[0x00D9] = 600;
            DefaultWidths[0x0056] = 600;
            DefaultWidths[0x0057] = 600;
            DefaultWidths[0x0058] = 600;
            DefaultWidths[0x0059] = 600;
            DefaultWidths[0x00DD] = 600;
            DefaultWidths[0x009F] = 600;
            DefaultWidths[0x005A] = 600;
            DefaultWidths[0x0061] = 600;
            DefaultWidths[0x00E1] = 600;
            DefaultWidths[0x00E2] = 600;
            DefaultWidths[0x00B4] = 600;
            DefaultWidths[0x00E4] = 600;
            DefaultWidths[0x00E6] = 600;
            DefaultWidths[0x00E0] = 600;
            DefaultWidths[0x0026] = 600;
            DefaultWidths[0x00E5] = 600;
            DefaultWidths[0xAB] = 600;
            DefaultWidths[0xAF] = 600;
            DefaultWidths[0xAC] = 600;
            DefaultWidths[0xAE] = 600;
            DefaultWidths[0xAD] = 600;
            DefaultWidths[0x005E] = 600;
            DefaultWidths[0x007E] = 600;
            DefaultWidths[0x002A] = 600;
            DefaultWidths[0x0040] = 600;
            DefaultWidths[0x00E3] = 600;
            DefaultWidths[0x0062] = 600;
            DefaultWidths[0x005C] = 600;
            DefaultWidths[0x007C] = 600;
            DefaultWidths[0x007B] = 600;
            DefaultWidths[0x007D] = 600;
            DefaultWidths[0x005B] = 600;
            DefaultWidths[0x005D] = 600;
            DefaultWidths[0x00A6] = 600;
            DefaultWidths[0x0095] = 600;
            DefaultWidths[0x0063] = 600;
            DefaultWidths[0x00E7] = 600;
            DefaultWidths[0x00B8] = 600;
            DefaultWidths[0x00A2] = 600;
            DefaultWidths[0x0088] = 600;
            DefaultWidths[0x003A] = 600;
            DefaultWidths[0x002C] = 600;
            DefaultWidths[0x00A9] = 600;
            DefaultWidths[0x00A4] = 600;
            DefaultWidths[0x0064] = 600;
            DefaultWidths[0x0086] = 600;
            DefaultWidths[0x0087] = 600;
            DefaultWidths[0x00B0] = 600;
            DefaultWidths[0x00A8] = 600;
            DefaultWidths[0x00F7] = 600;
            DefaultWidths[0x0024] = 600;
            DefaultWidths[0x0065] = 600;
            DefaultWidths[0x00E9] = 600;
            DefaultWidths[0x00EA] = 600;
            DefaultWidths[0x00EB] = 600;
            DefaultWidths[0x00E8] = 600;
            DefaultWidths[0x0038] = 600;
            DefaultWidths[0x0085] = 600;
            DefaultWidths[0x0097] = 600;
            DefaultWidths[0x0096] = 600;
            DefaultWidths[0x003D] = 600;
            DefaultWidths[0x00F0] = 600;
            DefaultWidths[0x0021] = 600;
            DefaultWidths[0x00A1] = 600;
            DefaultWidths[0x0066] = 600;
            DefaultWidths[0x0035] = 600;
            DefaultWidths[0x0083] = 600;
            DefaultWidths[0x0034] = 600;
            DefaultWidths[0xA4] = 600;
            DefaultWidths[0x0067] = 600;
            DefaultWidths[0x00DF] = 600;
            DefaultWidths[0x0060] = 600;
            DefaultWidths[0x003E] = 600;
            DefaultWidths[0x00AB] = 600;
            DefaultWidths[0x00BB] = 600;
            DefaultWidths[0x008B] = 600;
            DefaultWidths[0x009B] = 600;
            DefaultWidths[0x0068] = 600;
            DefaultWidths[0x002D] = 600;
            DefaultWidths[0x0069] = 600;
            DefaultWidths[0x00ED] = 600;
            DefaultWidths[0x00EE] = 600;
            DefaultWidths[0x00EF] = 600;
            DefaultWidths[0x00EC] = 600;
            DefaultWidths[0x006A] = 600;
            DefaultWidths[0x006B] = 600;
            DefaultWidths[0x006C] = 600;
            DefaultWidths[0x003C] = 600;
            DefaultWidths[0x00AC] = 600;
            DefaultWidths[0x006D] = 600;
            DefaultWidths[0x00AF] = 600;
            DefaultWidths[0x2D] = 600;
            DefaultWidths[0x00B5] = 600;
            DefaultWidths[0x00D7] = 600;
            DefaultWidths[0x006E] = 600;
            DefaultWidths[0x0039] = 600;
            DefaultWidths[0x00F1] = 600;
            DefaultWidths[0x0023] = 600;
            DefaultWidths[0x006F] = 600;
            DefaultWidths[0x00F3] = 600;
            DefaultWidths[0x00F4] = 600;
            DefaultWidths[0x00F6] = 600;
            DefaultWidths[0x009C] = 600;
            DefaultWidths[0x00F2] = 600;
            DefaultWidths[0x0031] = 600;
            DefaultWidths[0x00BD] = 600;
            DefaultWidths[0x00BC] = 600;
            DefaultWidths[0x00B9] = 600;
            DefaultWidths[0x00AA] = 600;
            DefaultWidths[0x00BA] = 600;
            DefaultWidths[0x00F8] = 600;
            DefaultWidths[0x00F5] = 600;
            DefaultWidths[0x0070] = 600;
            DefaultWidths[0x00B6] = 600;
            DefaultWidths[0x0028] = 600;
            DefaultWidths[0x0029] = 600;
            DefaultWidths[0x0025] = 600;
            DefaultWidths[0x002E] = 600;
            DefaultWidths[0x00B7] = 600;
            DefaultWidths[0x0089] = 600;
            DefaultWidths[0x002B] = 600;
            DefaultWidths[0x00B1] = 600;
            DefaultWidths[0x0071] = 600;
            DefaultWidths[0x003F] = 600;
            DefaultWidths[0x00BF] = 600;
            DefaultWidths[0x0022] = 600;
            DefaultWidths[0x0084] = 600;
            DefaultWidths[0x0093] = 600;
            DefaultWidths[0x0094] = 600;
            DefaultWidths[0x0091] = 600;
            DefaultWidths[0x0092] = 600;
            DefaultWidths[0x0082] = 600;
            DefaultWidths[0x0027] = 600;
            DefaultWidths[0x0072] = 600;
            DefaultWidths[0x00AE] = 600;
            DefaultWidths[0x0073] = 600;
            DefaultWidths[0x009A] = 600;
            DefaultWidths[0x00A7] = 600;
            DefaultWidths[0x003B] = 600;
            DefaultWidths[0x0037] = 600;
            DefaultWidths[0x0036] = 600;
            DefaultWidths[0x002F] = 600;
            DefaultWidths[0x0020] = 600;
            DefaultWidths[0x00A0] = 600;
            DefaultWidths[0x00A3] = 600;
            DefaultWidths[0x0074] = 600;
            DefaultWidths[0x00FE] = 600;
            DefaultWidths[0x0033] = 600;
            DefaultWidths[0x00BE] = 600;
            DefaultWidths[0x00B3] = 600;
            DefaultWidths[0x0098] = 600;
            DefaultWidths[0x0099] = 600;
            DefaultWidths[0x0032] = 600;
            DefaultWidths[0x00B2] = 600;
            DefaultWidths[0x0075] = 600;
            DefaultWidths[0x00FA] = 600;
            DefaultWidths[0x00FB] = 600;
            DefaultWidths[0x00FC] = 600;
            DefaultWidths[0x00F9] = 600;
            DefaultWidths[0x005F] = 600;
            DefaultWidths[0x0076] = 600;
            DefaultWidths[0x0077] = 600;
            DefaultWidths[0x0078] = 600;
            DefaultWidths[0x0079] = 600;
            DefaultWidths[0x00FD] = 600;
            DefaultWidths[0x00FF] = 600;
            DefaultWidths[0x00A5] = 600;
            DefaultWidths[0x007A] = 600;
            DefaultWidths[0x0030] = 600;
        }
    }
}