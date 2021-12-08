using Melanchall.DryWetMidi.Core;
using Melanchall.DryWetMidi.Interaction;
using FuzzySharp;
using Melanchall.DryWetMidi.Multimedia;

namespace musical_synthesizer
{
    public partial class Form1 : Form
    {
        List<int> notes = new List<int>();

        private static Playback _playback;


        public void reset_color()
        {
            this.key0.BackColor = System.Drawing.Color.White;
            this.key1.BackColor = System.Drawing.Color.Black;
            this.key2.BackColor = System.Drawing.Color.White;
            this.key3.BackColor = System.Drawing.Color.Black;
            this.key4.BackColor = System.Drawing.Color.White;
            this.key5.BackColor = System.Drawing.Color.Black;
            this.key6.BackColor = System.Drawing.Color.White;
            this.key7.BackColor = System.Drawing.Color.Black;
            this.key8.BackColor = System.Drawing.Color.White;
        }

        public string get_midifile(string result)
        {
            string[] files = Directory.GetFiles(@"C:\Users\Admin\source\repos\musical synthesizer\songfiles");

            System.Diagnostics.Debug.WriteLine("Total midi files = " + files.Count());
            string unknown_notes = result;
            int c = 0;
            var lines = File.ReadAllLines(@"C:\Users\Admin\source\repos\musical synthesizer\notes_array.txt");
            int max = 0;
            int index = 0;
            foreach (var line in lines)
            {
                int v = Fuzz.PartialRatio(unknown_notes, line);
                //Console.WriteLine(c+" = "+v);
                if (v > max)
                {
                    max = v;
                    index = c;
                }
                //Console.WriteLine("Max = " + max);
                //Console.WriteLine("Index = " + index);
                if (c == files.Count() - 1) { break; }
                c++;
            }
            //Console.WriteLine(c);
            System.Diagnostics.Debug.WriteLine("Closest Match = " + files[index]);
            
            System.Diagnostics.Debug.WriteLine("Playing: " + files[index]);
            var midiFile = MidiFile.Read(files[index]);

            var outputDevice = OutputDevice.GetByName("Microsoft GS Wavetable Synth");

            _playback = midiFile.GetPlayback(outputDevice);
            // _playback.NotesPlaybackStarted += OnNotesPlaybackStarted;
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
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string result = "";
            foreach (int i in notes)
            {
                result += i.ToString();
            }

            MessageBox.Show(result);
            string final_note = get_midifile(result);

            System.Diagnostics.Debug.WriteLine(final_note);

            notes.Clear();

            MessageBox.Show(final_note);
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
    }
}
