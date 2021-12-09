using Melanchall.DryWetMidi.Core;
using Melanchall.DryWetMidi.Interaction;
using FuzzySharp;
using Melanchall.DryWetMidi.Multimedia;
using System.IO.Ports;

namespace NSCmusical
{
    public partial class Form1 : Form
    {
        List<int> notes = new List<int>();

        private static Playback _playback;
        static SerialPort _serialPort;


        public void reset_color()
        {
            this.key0.BackColor = System.Drawing.Color.White;
            this.key1.BackColor = System.Drawing.Color.Black;
            this.key2.BackColor = System.Drawing.Color.White;
            this.key3.BackColor = System.Drawing.Color.Black;
            this.key4.BackColor = System.Drawing.Color.White;
            this.key5.BackColor = System.Drawing.Color.White;
            this.key6.BackColor = System.Drawing.Color.Black;
            this.key7.BackColor = System.Drawing.Color.White;
            this.key8.BackColor = System.Drawing.Color.Black;
            this.key9.BackColor = System.Drawing.Color.White;
            this.key10.BackColor = System.Drawing.Color.Black;
            this.key11.BackColor = System.Drawing.Color.White;
            this.key12.BackColor = System.Drawing.Color.White;
            this.key13.BackColor = System.Drawing.Color.Black;
            this.key14.BackColor = System.Drawing.Color.White;
            this.key15.BackColor = System.Drawing.Color.Black;
            this.key16.BackColor = System.Drawing.Color.White;
            this.key17.BackColor = System.Drawing.Color.White;
            this.key18.BackColor = System.Drawing.Color.Black;
            this.key19.BackColor = System.Drawing.Color.White;
            this.key20.BackColor = System.Drawing.Color.Black;
            this.key21.BackColor = System.Drawing.Color.White;
            this.key22.BackColor = System.Drawing.Color.Black;
            this.key23.BackColor = System.Drawing.Color.White;
            this.key24.BackColor = System.Drawing.Color.White;
            this.key25.BackColor = System.Drawing.Color.Black;
            this.key26.BackColor = System.Drawing.Color.White;
            this.key27.BackColor = System.Drawing.Color.Black;
            this.key28.BackColor = System.Drawing.Color.White;
            this.key29.BackColor = System.Drawing.Color.White;
            this.key30.BackColor = System.Drawing.Color.White;
            this.key31.BackColor = System.Drawing.Color.Black;
            this.key32.BackColor = System.Drawing.Color.Black;
            this.key33.BackColor = System.Drawing.Color.White;
            this.key34.BackColor = System.Drawing.Color.Black;
            this.key35.BackColor = System.Drawing.Color.White;
            this.key36.BackColor = System.Drawing.Color.White;
            this.key37.BackColor = System.Drawing.Color.Black;
            this.key38.BackColor = System.Drawing.Color.White;
            this.key39.BackColor = System.Drawing.Color.Black;
            this.key40.BackColor = System.Drawing.Color.White;
            this.key41.BackColor = System.Drawing.Color.White;
            this.key42.BackColor = System.Drawing.Color.Black;
            this.key43.BackColor = System.Drawing.Color.White;
            this.key44.BackColor = System.Drawing.Color.Black;
            this.key45.BackColor = System.Drawing.Color.White;
            this.key46.BackColor = System.Drawing.Color.Black;
            this.key47.BackColor = System.Drawing.Color.White;
            this.key48.BackColor = System.Drawing.Color.White;
            this.key49.BackColor = System.Drawing.Color.Black;
            this.key50.BackColor = System.Drawing.Color.White;
            this.key51.BackColor = System.Drawing.Color.Black;
            this.key52.BackColor = System.Drawing.Color.White;
            this.key53.BackColor = System.Drawing.Color.White;
            this.key54.BackColor = System.Drawing.Color.Black;
            this.key55.BackColor = System.Drawing.Color.White;
            this.key56.BackColor = System.Drawing.Color.Black;
            this.key57.BackColor = System.Drawing.Color.White;
            this.key58.BackColor = System.Drawing.Color.Black;
            this.key59.BackColor = System.Drawing.Color.White;
            this.key60.BackColor = System.Drawing.Color.White;
        }

        public string get_midifile(string result)
        {
            string[] files = Directory.GetFiles(@"C:\Users\rites\source\repos\NSCmusical\songfiles");

            System.Diagnostics.Debug.WriteLine("Total midi files = " + files.Count());
            string unknown_notes = result;
            int c = 0;
            var lines = File.ReadAllLines(@"C:\Users\rites\source\repos\NSCmusical\notes_array.txt");
            int max = 0;
            int index = 0;
            foreach (var line in lines)
            {
                int v = Fuzz.PartialRatio(unknown_notes, line);
                if (v > max)
                {
                    max = v;
                    index = c;
                }
                if (c == files.Count() - 1) { break; }
                c++;
            }
            System.Diagnostics.Debug.WriteLine("Closest Match = " + files[index]);

            System.Diagnostics.Debug.WriteLine("Playing: " + files[index]);

            MessageBox.Show("Playing: " + files[index]);

            var midiFile = MidiFile.Read(files[index]);

            var outputDevice = OutputDevice.GetByName("Microsoft GS Wavetable Synth");

            _playback = midiFile.GetPlayback(outputDevice);
            _playback.Start();

            SpinWait.SpinUntil(() => !_playback.IsRunning);

            System.Diagnostics.Debug.WriteLine("Playback stopped or finished.");

            outputDevice.Dispose();
            _playback.Dispose();

            return lines[index];
        }

        public Form1()
        {
            InitializeComponent();
            _serialPort = new SerialPort("COM3", 9600);
            _serialPort.Open();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string result = "";
            foreach (int i in notes)
            {
                result += i.ToString() + " ";
            }

            MessageBox.Show(result);
            string final_note = get_midifile(result);

            System.Diagnostics.Debug.WriteLine(final_note);

            notes.Clear();

            MessageBox.Show(final_note);
            _serialPort.Write(final_note);
        }

        private void key0_Click(object sender, EventArgs e)
        {
            notes.Add(0);
            reset_color();
            this.key0.BackColor = System.Drawing.Color.Green;
        }

        private void key1_Click(object sender, EventArgs e)
        {
            notes.Add(1);
            reset_color();
            this.key1.BackColor = System.Drawing.Color.Green;
        }

        private void key2_Click(object sender, EventArgs e)
        {
            notes.Add(2);
            reset_color();
            this.key2.BackColor = System.Drawing.Color.Green;
        }

        private void key3_Click(object sender, EventArgs e)
        {
            notes.Add(3);
            reset_color();
            this.key3.BackColor = System.Drawing.Color.Green;
        }

        private void key4_Click(object sender, EventArgs e)
        {
            notes.Add(4);
            reset_color();
            this.key4.BackColor = System.Drawing.Color.Green;
        }

        private void key5_Click(object sender, EventArgs e)
        {
            notes.Add(5);
            reset_color();
            this.key5.BackColor = System.Drawing.Color.Green;
        }

        private void key6_Click(object sender, EventArgs e)
        {
            notes.Add(6);
            reset_color();
            this.key6.BackColor = System.Drawing.Color.Green;
        }

        private void key7_Click(object sender, EventArgs e)
        {
            notes.Add(7);
            reset_color();
            this.key7.BackColor = System.Drawing.Color.Green;
        }

        private void key8_Click(object sender, EventArgs e)
        {
            notes.Add(8);
            reset_color();
            this.key8.BackColor = System.Drawing.Color.Green;
        }

        private void key9_Click(object sender, EventArgs e)
        {
            notes.Add(9);
            reset_color();
            this.key9.BackColor = System.Drawing.Color.Green;
        }

        private void key10_Click(object sender, EventArgs e)
        {
            notes.Add(10);
            reset_color();
            this.key10.BackColor = System.Drawing.Color.Green;
        }

        private void key11_Click(object sender, EventArgs e)
        {
            notes.Add(11);
            reset_color();
            this.key11.BackColor = System.Drawing.Color.Green;
        }

        private void key12_Click(object sender, EventArgs e)
        {
            notes.Add(12);
            reset_color();
            this.key12.BackColor = System.Drawing.Color.Green;
        }

        private void key13_Click(object sender, EventArgs e)
        {
            notes.Add(13);
            reset_color();
            this.key13.BackColor = System.Drawing.Color.Green;
        }

        private void key14_Click(object sender, EventArgs e)
        {
            notes.Add(14);
            reset_color();
            this.key14.BackColor = System.Drawing.Color.Green;
        }

        private void key15_Click(object sender, EventArgs e)
        {
            notes.Add(15);
            reset_color();
            this.key15.BackColor = System.Drawing.Color.Green;
        }

        private void key16_Click(object sender, EventArgs e)
        {
            notes.Add(16);
            reset_color();
            this.key16.BackColor = System.Drawing.Color.Green;
        }

        private void key17_Click(object sender, EventArgs e)
        {
            notes.Add(17);
            reset_color();
            this.key17.BackColor = System.Drawing.Color.Green;
        }

        private void key18_Click(object sender, EventArgs e)
        {
            notes.Add(18);
            reset_color();
            this.key18.BackColor = System.Drawing.Color.Green;
        }

        private void key19_Click(object sender, EventArgs e)
        {
            notes.Add(19);
            reset_color();
            this.key19.BackColor = System.Drawing.Color.Green;
        }

        private void key20_Click(object sender, EventArgs e)
        {
            notes.Add(20);
            reset_color();
            this.key20.BackColor = System.Drawing.Color.Green;
        }

        private void key21_Click(object sender, EventArgs e)
        {
            notes.Add(21);
            reset_color();
            this.key21.BackColor = System.Drawing.Color.Green;
        }

        private void key22_Click(object sender, EventArgs e)
        {
            notes.Add(22);
            reset_color();
            this.key22.BackColor = System.Drawing.Color.Green;
        }

        private void key23_Click(object sender, EventArgs e)
        {
            notes.Add(23);
            reset_color();
            this.key23.BackColor = System.Drawing.Color.Green;
        }

        private void key24_Click(object sender, EventArgs e)
        {
            notes.Add(24);
            reset_color();
            this.key24.BackColor = System.Drawing.Color.Green;
        }

        private void key25_Click(object sender, EventArgs e)
        {
            notes.Add(25);
            reset_color();
            this.key25.BackColor = System.Drawing.Color.Green;
        }

        private void key26_Click(object sender, EventArgs e)
        {
            notes.Add(26);
            reset_color();
            this.key26.BackColor = System.Drawing.Color.Green;
        }

        private void key27_Click(object sender, EventArgs e)
        {
            notes.Add(27);
            reset_color();
            this.key27.BackColor = System.Drawing.Color.Green;
        }

        private void key28_Click(object sender, EventArgs e)
        {
            notes.Add(28);
            reset_color();
            this.key28.BackColor = System.Drawing.Color.Green;
        }

        private void key29_Click(object sender, EventArgs e)
        {
            notes.Add(29);
            reset_color();
            this.key29.BackColor = System.Drawing.Color.Green;
        }

        private void key30_Click(object sender, EventArgs e)
        {
            notes.Add(30);
            reset_color();
            this.key30.BackColor = System.Drawing.Color.Green;
        }

        private void key31_Click(object sender, EventArgs e)
        {
            notes.Add(31);
            reset_color();
            this.key31.BackColor = System.Drawing.Color.Green;
        }

        private void key32_Click(object sender, EventArgs e)
        {
            notes.Add(32);
            reset_color();
            this.key32.BackColor = System.Drawing.Color.Green;
        }

        private void key33_Click(object sender, EventArgs e)
        {
            notes.Add(33);
            reset_color();
            this.key33.BackColor = System.Drawing.Color.Green;
        }

        private void key34_Click(object sender, EventArgs e)
        {
            notes.Add(34);
            reset_color();
            this.key34.BackColor = System.Drawing.Color.Green;
        }

        private void key35_Click(object sender, EventArgs e)
        {
            notes.Add(35);
            reset_color();
            this.key35.BackColor = System.Drawing.Color.Green;
        }

        private void key36_Click(object sender, EventArgs e)
        {
            notes.Add(36);
            reset_color();
            this.key36.BackColor = System.Drawing.Color.Green;
        }

        private void key37_Click(object sender, EventArgs e)
        {
            notes.Add(37);
            reset_color();
            this.key37.BackColor = System.Drawing.Color.Green;
        }

        private void key38_Click(object sender, EventArgs e)
        {
            notes.Add(38);
            reset_color();
            this.key38.BackColor = System.Drawing.Color.Green;
        }

        private void key39_Click(object sender, EventArgs e)
        {
            notes.Add(39);
            reset_color();
            this.key39.BackColor = System.Drawing.Color.Green;
        }

        private void key40_Click(object sender, EventArgs e)
        {
            notes.Add(40);
            reset_color();
            this.key40.BackColor = System.Drawing.Color.Green;
        }

        private void key41_Click(object sender, EventArgs e)
        {
            notes.Add(41);
            reset_color();
            this.key41.BackColor = System.Drawing.Color.Green;
        }

        private void key42_Click(object sender, EventArgs e)
        {
            notes.Add(42);
            reset_color();
            this.key42.BackColor = System.Drawing.Color.Green;
        }

        private void key43_Click(object sender, EventArgs e)
        {
            notes.Add(43);
            reset_color();
            this.key43.BackColor = System.Drawing.Color.Green;
        }

        private void key44_Click(object sender, EventArgs e)
        {
            notes.Add(44);
            reset_color();
            this.key44.BackColor = System.Drawing.Color.Green;
        }

        private void key45_Click(object sender, EventArgs e)
        {
            notes.Add(45);
            reset_color();
            this.key45.BackColor = System.Drawing.Color.Green;
        }

        private void key46_Click(object sender, EventArgs e)
        {
            notes.Add(46);
            reset_color();
            this.key46.BackColor = System.Drawing.Color.Green;
        }

        private void key47_Click(object sender, EventArgs e)
        {
            notes.Add(47);
            reset_color();
            this.key47.BackColor = System.Drawing.Color.Green;
        }

        private void key48_Click(object sender, EventArgs e)
        {
            notes.Add(48);
            reset_color();
            this.key48.BackColor = System.Drawing.Color.Green;
        }

        private void key49_Click(object sender, EventArgs e)
        {
            notes.Add(49);
            reset_color();
            this.key49.BackColor = System.Drawing.Color.Green;
        }

        private void key50_Click(object sender, EventArgs e)
        {
            notes.Add(50);
            reset_color();
            this.key50.BackColor = System.Drawing.Color.Green;
        }

        private void key51_Click(object sender, EventArgs e)
        {
            notes.Add(51);
            reset_color();
            this.key51.BackColor = System.Drawing.Color.Green;
        }

        private void key52_Click(object sender, EventArgs e)
        {
            notes.Add(52);
            reset_color();
            this.key52.BackColor = System.Drawing.Color.Green;
        }

        private void key53_Click(object sender, EventArgs e)
        {
            notes.Add(53);
            reset_color();
            this.key53.BackColor = System.Drawing.Color.Green;
        }

        private void key54_Click(object sender, EventArgs e)
        {
            notes.Add(54);
            reset_color();
            this.key54.BackColor = System.Drawing.Color.Green;
        }

        private void key55_Click(object sender, EventArgs e)
        {
            notes.Add(55);
            reset_color();
            this.key55.BackColor = System.Drawing.Color.Green;
        }

        private void key56_Click(object sender, EventArgs e)
        {
            notes.Add(56);
            reset_color();
            this.key56.BackColor = System.Drawing.Color.Green;
        }

        private void key57_Click(object sender, EventArgs e)
        {
            notes.Add(57);
            reset_color();
            this.key57.BackColor = System.Drawing.Color.Green;
        }

        private void key58_Click(object sender, EventArgs e)
        {
            notes.Add(58);
            reset_color();
            this.key58.BackColor = System.Drawing.Color.Green;
        }

        private void key59_Click(object sender, EventArgs e)
        {
            notes.Add(59);
            reset_color();
            this.key59.BackColor = System.Drawing.Color.Green;
        }

        private void key60_Click(object sender, EventArgs e)
        {
            notes.Add(60);
            reset_color();
            this.key60.BackColor = System.Drawing.Color.Green;
        }
    }
}
