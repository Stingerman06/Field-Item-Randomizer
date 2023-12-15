namespace Field_Item_Randomizer
{
    public class Randomize
    {
        public static uint[] noLocks = { 0x00030105,      // Onion Knight                 ~ 0
                                   0x001A0105,      // World Champion               ~ 1
                                   0x001E0105,      // Masamuna                     ~ 2
                                   0x00240105,      // Nirvana                      ~ 3
                                   0x00250105,      // Caladbolg                    ~ 4
                                   0x00380105,      // Spirit Lance                 ~ 5
                                   0x003D0105,      // Godhand                      ~ 6
                                   0xA021010A,      // Rusty Sword                  ~ 7
                                   0xA002010A};     // Cloudy Mirror                ~ 8

        public static int[] noLockSlots = { 5,           // Cloudy Mirror                ~ 3
                                       93,          // Cloudy Mirror                ~ 91
                                       99,          // Cloudy Mirror | Rusty Sword  ~ 97
                                       113,         // Cloudy Mirror                ~ 110
                                       114,         // Cloudy Mirror                ~ 111
                                       118,         // Cloudy Mirror                ~ 115
                                       188,         // Cloudy Mirror                ~ 184
                                       214};        // Cloudy Mirror                ~ 210

        public static uint[] noRandomize = { 0xA000010A,  // Withered Bouquet             ~ 0
                                       0xA001010A,  // Flint                        ~ 1
                                       0xA003010A,  // Celestial Mirror             ~ 2
                                       0xA020010A,  // Jecht's Sphere               ~ 3
                                       2,           // Withered Bouquet             ~ 4
                                       3,           // Flint                        ~ 5
                                       111,         // Celestial Mirror             ~ 6
                                       177};        // Jecht's Sphere               ~ 7

        public static FileStream? loadFile;
        public static FileStream? saveFile;
        public static void Main(string save, string load, int seed)
        {
            string loadFileLocation = load;   //Parse from other file
            string saveFileLocation = save;   //Parse from other file
            int randSeed = seed;                   //Parse from other file
            string seedString;
            if (randSeed == 0)
            {
                Random rand = new Random();
                randSeed = rand.Next();
            }
            seedString = randSeed.ToString();
            if (loadFile != null)
            {
                loadFile = null;
            }
            loadFile = new FileStream(loadFileLocation, FileMode.Open, FileAccess.Read);
            loadFile.Position = 0x14;
            byte[] buffer = new byte[4];
            uint[] shuffle = new uint[(loadFile.Length / 4) - 5];
            uint[] outArray = new uint[(loadFile.Length / 4) - 5];
            for (int i = 0; i < shuffle.Length; i++)
            {
                buffer[0] = (byte)loadFile.ReadByte();
                buffer[1] = (byte)loadFile.ReadByte();
                buffer[2] = (byte)loadFile.ReadByte();
                buffer[3] = (byte)loadFile.ReadByte();

                shuffle[i] = BitConverter.ToUInt32(buffer, 0);
            }
            bool randomizeBad = true;
            int failSafe = 0;
            while (randomizeBad)
            {
                Shuffle(randSeed, shuffle, out outArray);
                RandomCheck(outArray, out randomizeBad);
                if (!randomizeBad)
                {
                    break;
                }
                if (randSeed++ > int.MaxValue)
                {
                    randSeed = int.MinValue;
                }
                else
                {
                    randSeed++;
                }
                failSafe++;
                if (failSafe == 25)
                {
                    break;
                }
            }
            if (randomizeBad)
            {
                loadFile.Dispose();
                loadFile.Close();
                loadFile = null;
                return;
            }
            loadFile.Position = 0;
            if (saveFile != null)
            {
                saveFile.Dispose();
                saveFile.Close();
                saveFile = null;
            }
            saveFileLocation += "\\takara(" + seedString + ").bin";
            while (File.Exists(saveFileLocation))
            {
                saveFileLocation += "(new)";
            }
            saveFile = new FileStream(saveFileLocation, FileMode.CreateNew, FileAccess.ReadWrite);
            for (int i = 0; i < 0x14; i++)
            {
                saveFile.WriteByte((byte)loadFile.ReadByte());
            }
            for (int i = 0; i < outArray.Length; i++)
            {
                buffer = BitConverter.GetBytes(outArray[i]);
                for (int j = 0; j < 4; j++)
                {
                    saveFile.WriteByte(buffer[j]);
                }
            }
            saveFile.Dispose();
            saveFile.Close();
            saveFile = null;
            loadFile.Dispose();
            loadFile.Close();
            loadFile = null;
            return;
        }
        public static uint[] Shuffle(int seed, uint[] array, out uint[] arrayOut)
        {
            arrayOut = array;
            int j = 0;
            Random rand = new Random(seed);
            for (int i = 0; i < arrayOut.Length; i++)
            {
                if (i == 2 || i == 3 || i == 111 || i == 177)
                {
                    arrayOut[i] = noRandomize[j];
                    j++;
                    continue;
                }
                int r = rand.Next(i, array.Length);
                while (r == 2 || r == 3 || r == 111 || r == 177)
                {
                    r++;
                }
                if ((noLockSlots.Contains(i) && array[r] == noLocks[8])
                 || (noLockSlots.Contains(r) && array[i] == noLocks[8])
                 || (i == 99 && array[r] == noLocks[7])
                 || (r == 99 && array[i] == noLocks[7]))
                {

                }
                else
                {
                    (array[r], array[i]) = (array[i], array[r]);
                }
            }
            return arrayOut;
        }
        public static bool RandomCheck(uint[] array, out bool randomizeBad)
        {
            // TODO: Check the appropriate slots against the proper randomized items. If it checks out ok, randomizeBad = false.

            for (int i = 0; i < array.Length; i++)
            {
                if ((i == 2 && array[i] != noRandomize[0])              // Check for Withered Bouquet
                 || (i == 3 && array[i] != noRandomize[1])              // Check for Flint
                 || (i == 111 && array[i] != noRandomize[2])            // Check for Celestial Mirror
                 || (i == 177 && array[i] != noRandomize[3])            // Check for Jecht's Sphere
                 || (noLockSlots.Contains(i) && array[i] == noLocks[8]) // Check for Cloudy Mirror
                 || (i == 99 && array[i] == noLocks[7]))                // Check for Rusty Sword
                {
                    randomizeBad = true;
                    return randomizeBad;
                }
            }
            randomizeBad = false;
            return randomizeBad;
        }
    }
}