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

        public void reset()
        {
            int y = 440;
            int y2 = y + 388;
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;

            int buttonWidth = screenWidth / 36;
            int buttonHeight = 243;

            int smallBtnWidth = buttonWidth - 10;
            int smallBtnHeight = buttonHeight - 100;

            int animateHeight = screenHeight - buttonHeight - 7;

            this.label1.Location = new Point(screenWidth / 2 - buttonWidth*4, 20);
            this.pictureBox1.Location = new Point(screenWidth/2 - buttonWidth, 80);
            this.button1.Location = new Point(screenWidth / 2 - buttonWidth*4, 280);

            this.key_0.Location = new Point(0, 0);
            this.key_0.Size = new Size(buttonWidth, animateHeight);

            this.key_2.Location = new Point(buttonWidth, 0);
            this.key_2.Size = new Size(buttonWidth, animateHeight);

            this.key_4.Location = new Point(buttonWidth*2, 0);
            this.key_4.Size = new Size(buttonWidth, animateHeight);

            this.key_5.Location = new Point(buttonWidth*3, 0);
            this.key_5.Size = new Size(buttonWidth, animateHeight);

            this.key_7.Location = new Point(buttonWidth*4, 0);
            this.key_7.Size = new Size(buttonWidth, animateHeight);

            this.key_9.Location = new Point(buttonWidth*5, 0);
            this.key_9.Size = new Size(buttonWidth, animateHeight);

            this.key_11.Location = new Point(buttonWidth*6, 0);
            this.key_11.Size = new Size(buttonWidth, animateHeight);

            this.key_12.Location = new Point(buttonWidth*7, 0);
            this.key_12.Size = new Size(buttonWidth, animateHeight);

            this.key_14.Location = new Point(buttonWidth*8, 0);
            this.key_14.Size = new Size(buttonWidth, animateHeight);

            this.key_16.Location = new Point(buttonWidth*9, 0);
            this.key_16.Size = new Size(buttonWidth, animateHeight);

            this.key_17.Location = new Point(buttonWidth*10, 0);
            this.key_17.Size = new Size(buttonWidth, animateHeight);

            this.key_19.Location = new Point(buttonWidth*11, 0);
            this.key_19.Size = new Size(buttonWidth, animateHeight);

            this.key_21.Location = new Point(buttonWidth*12, 0);
            this.key_21.Size = new Size(buttonWidth, animateHeight);

            this.key_23.Location = new Point(buttonWidth*13, 0);
            this.key_23.Size = new Size(buttonWidth, animateHeight);

            this.key_24.Location = new Point(buttonWidth*14, 0);
            this.key_24.Size = new Size(buttonWidth, animateHeight);

            this.key_26.Location = new Point(buttonWidth*15, 0);
            this.key_26.Size = new Size(buttonWidth, animateHeight);

            this.key_28.Location = new Point(buttonWidth*16, 0);
            this.key_28.Size = new Size(buttonWidth, animateHeight);

            this.key_29.Location = new Point(buttonWidth*17, 0);
            this.key_29.Size = new Size(buttonWidth, animateHeight);

            this.key_30.Location = new Point(buttonWidth*18, 0);
            this.key_30.Size = new Size(buttonWidth, animateHeight);

            this.key_33.Location = new Point(buttonWidth*19, 0);
            this.key_33.Size = new Size(buttonWidth, animateHeight);

            this.key_35.Location = new Point(buttonWidth*20, 0);
            this.key_35.Size = new Size(buttonWidth, animateHeight);

            this.key_36.Location = new Point(buttonWidth*21, 0);
            this.key_36.Size = new Size(buttonWidth, animateHeight);

            this.key_38.Location = new Point(buttonWidth*22, 0);
            this.key_38.Size = new Size(buttonWidth, animateHeight);

            this.key_40.Location = new Point(buttonWidth*23, 0);
            this.key_40.Size = new Size(buttonWidth, animateHeight);

            this.key_41.Location = new Point(buttonWidth*24, 0);
            this.key_41.Size = new Size(buttonWidth, animateHeight);

            this.key_43.Location = new Point(buttonWidth*25, 0);
            this.key_43.Size = new Size(buttonWidth, animateHeight);

            this.key_45.Location = new Point(buttonWidth*26, 0);
            this.key_45.Size = new Size(buttonWidth, animateHeight);

            this.key_47.Location = new Point(buttonWidth*27, 0);
            this.key_47.Size = new Size(buttonWidth, animateHeight);

            this.key_48.Location = new Point(buttonWidth*28, 0);
            this.key_48.Size = new Size(buttonWidth, animateHeight);

            this.key_50.Location = new Point(buttonWidth*29, 0);
            this.key_50.Size = new Size(buttonWidth, animateHeight);

            this.key_52.Location = new Point(buttonWidth*30, 0);
            this.key_52.Size = new Size(buttonWidth, animateHeight);

            this.key_53.Location = new Point(buttonWidth*31, 0);
            this.key_53.Size = new Size(buttonWidth, animateHeight);

            this.key_55.Location = new Point(buttonWidth*32, 0);
            this.key_55.Size = new Size(buttonWidth, animateHeight);

            this.key_57.Location = new Point(buttonWidth*33, 0);
            this.key_57.Size = new Size(buttonWidth, animateHeight);

            this.key_59.Location = new Point(buttonWidth*34, 0);
            this.key_59.Size = new Size(buttonWidth, animateHeight);

            this.key_60.Location = new Point(buttonWidth*35, 0);
            this.key_60.Size = new Size(buttonWidth, animateHeight);

            this.key0.Location = new System.Drawing.Point(0, y);
            this.key0.Size = new System.Drawing.Size(buttonWidth, buttonHeight);

            this.key2.Location = new System.Drawing.Point(buttonWidth, y);
            this.key2.Size = new System.Drawing.Size(buttonWidth, buttonHeight);

            this.key4.Location = new System.Drawing.Point(buttonWidth*2, y);
            this.key4.Size = new System.Drawing.Size(buttonWidth, buttonHeight);

            this.key5.Location = new System.Drawing.Point(buttonWidth*3, y);
            this.key5.Size = new System.Drawing.Size(buttonWidth, buttonHeight);

            this.key7.Location = new System.Drawing.Point(buttonWidth*4, y);
            this.key7.Size = new System.Drawing.Size(buttonWidth, buttonHeight);

            this.key9.Location = new System.Drawing.Point(buttonWidth*5, y);
            this.key9.Size = new System.Drawing.Size(buttonWidth, buttonHeight);

            this.key11.Location = new System.Drawing.Point(buttonWidth*6, y);
            this.key11.Size = new System.Drawing.Size(buttonWidth, buttonHeight);

            this.key12.Location = new System.Drawing.Point(buttonWidth*7, y);
            this.key12.Size = new System.Drawing.Size(buttonWidth, buttonHeight);

            this.key14.Location = new System.Drawing.Point(buttonWidth*8, y);
            this.key14.Size = new System.Drawing.Size(buttonWidth, buttonHeight);

            this.key16.Location = new System.Drawing.Point(buttonWidth*9, y);
            this.key16.Size = new System.Drawing.Size(buttonWidth, buttonHeight);

            this.key17.Location = new System.Drawing.Point(buttonWidth*10, y);
            this.key17.Size = new System.Drawing.Size(buttonWidth, buttonHeight);

            this.key19.Location = new System.Drawing.Point(buttonWidth*11, y);
            this.key19.Size = new System.Drawing.Size(buttonWidth, buttonHeight);

            this.key21.Location = new System.Drawing.Point(buttonWidth*12, y);
            this.key21.Size = new System.Drawing.Size(buttonWidth, buttonHeight);

            this.key23.Location = new System.Drawing.Point(buttonWidth*13, y);
            this.key23.Size = new System.Drawing.Size(buttonWidth, buttonHeight);

            this.key24.Location = new System.Drawing.Point(buttonWidth*14, y);
            this.key24.Size = new System.Drawing.Size(buttonWidth, buttonHeight);

            this.key26.Location = new System.Drawing.Point(buttonWidth*15, y);
            this.key26.Size = new System.Drawing.Size(buttonWidth, buttonHeight);

            this.key28.Location = new System.Drawing.Point(buttonWidth*16, y);
            this.key28.Size = new System.Drawing.Size(buttonWidth, buttonHeight);

            this.key29.Location = new System.Drawing.Point(buttonWidth*17, y);
            this.key29.Size = new System.Drawing.Size(buttonWidth, buttonHeight);

            this.key30.Location = new System.Drawing.Point(buttonWidth*18, y);
            this.key30.Size = new System.Drawing.Size(buttonWidth, buttonHeight);

            this.key33.Location = new System.Drawing.Point(buttonWidth*19, y);
            this.key33.Size = new System.Drawing.Size(buttonWidth, buttonHeight);

            this.key35.Location = new System.Drawing.Point(buttonWidth*20, y);
            this.key35.Size = new System.Drawing.Size(buttonWidth, buttonHeight);

            this.key36.Location = new System.Drawing.Point(buttonWidth*21, y);
            this.key36.Size = new System.Drawing.Size(buttonWidth, buttonHeight);

            this.key38.Location = new System.Drawing.Point(buttonWidth*22, y);
            this.key38.Size = new System.Drawing.Size(buttonWidth, buttonHeight);

            this.key40.Location = new System.Drawing.Point(buttonWidth*23, y);
            this.key40.Size = new System.Drawing.Size(buttonWidth, buttonHeight);

            this.key41.Location = new System.Drawing.Point(buttonWidth*24, y);
            this.key41.Size = new System.Drawing.Size(buttonWidth, buttonHeight);

            this.key43.Location = new System.Drawing.Point(buttonWidth*25, y);
            this.key43.Size = new System.Drawing.Size(buttonWidth, buttonHeight);

            this.key45.Location = new System.Drawing.Point(buttonWidth*26, y);
            this.key45.Size = new System.Drawing.Size(buttonWidth, buttonHeight);

            this.key47.Location = new System.Drawing.Point(buttonWidth*27, y);
            this.key47.Size = new System.Drawing.Size(buttonWidth, buttonHeight);

            this.key48.Location = new System.Drawing.Point(buttonWidth*28, y);
            this.key48.Size = new System.Drawing.Size(buttonWidth, buttonHeight);

            this.key50.Location = new System.Drawing.Point(buttonWidth*29, y);
            this.key50.Size = new System.Drawing.Size(buttonWidth, buttonHeight);

            this.key52.Location = new System.Drawing.Point(buttonWidth*30, y);
            this.key52.Size = new System.Drawing.Size(buttonWidth, buttonHeight);

            this.key53.Location = new System.Drawing.Point(buttonWidth*31, y);
            this.key53.Size = new System.Drawing.Size(buttonWidth, buttonHeight);

            this.key55.Location = new System.Drawing.Point(buttonWidth*32, y);
            this.key55.Size = new System.Drawing.Size(buttonWidth, buttonHeight);

            this.key57.Location = new System.Drawing.Point(buttonWidth*33, y);
            this.key57.Size = new System.Drawing.Size(buttonWidth, buttonHeight);

            this.key59.Location = new System.Drawing.Point(buttonWidth*34, y);
            this.key59.Size = new System.Drawing.Size(buttonWidth, buttonHeight);

            this.key60.Location = new System.Drawing.Point(buttonWidth*35, y);
            this.key60.Size = new System.Drawing.Size(buttonWidth, buttonHeight);

            this.key1.Location = new System.Drawing.Point((int)(buttonWidth * 0.5), y2);
            this.key1.Size = new System.Drawing.Size(smallBtnWidth, smallBtnHeight);

            this.key3.Location = new System.Drawing.Point((int)(buttonWidth * 1.5), y2);
            this.key3.Size = new System.Drawing.Size(smallBtnWidth, smallBtnHeight);

            this.key6.Location = new System.Drawing.Point((int)(buttonWidth * 3.5), y2);
            this.key6.Size = new System.Drawing.Size(smallBtnWidth, smallBtnHeight);

            this.key8.Location = new System.Drawing.Point((int)(buttonWidth * 4.5), y2);
            this.key8.Size = new System.Drawing.Size(smallBtnWidth, smallBtnHeight);

            this.key10.Location = new System.Drawing.Point((int)(buttonWidth * 5.5), y2);
            this.key10.Size = new System.Drawing.Size(smallBtnWidth, smallBtnHeight);

            this.key13.Location = new System.Drawing.Point((int)(buttonWidth * 7.5), y2);
            this.key13.Size = new System.Drawing.Size(smallBtnWidth, smallBtnHeight);

            this.key15.Location = new System.Drawing.Point((int)(buttonWidth * 8.5), y2);
            this.key15.Size = new System.Drawing.Size(smallBtnWidth, smallBtnHeight);

            this.key18.Location = new System.Drawing.Point((int)(buttonWidth * 10.5), y2);
            this.key18.Size = new System.Drawing.Size(smallBtnWidth, smallBtnHeight);

            this.key20.Location = new System.Drawing.Point((int)(buttonWidth * 11.5), y2);
            this.key20.Size = new System.Drawing.Size(smallBtnWidth, smallBtnHeight);

            this.key22.Location = new System.Drawing.Point((int)(buttonWidth * 12.5), y2);
            this.key22.Size = new System.Drawing.Size(smallBtnWidth, smallBtnHeight);

            this.key25.Location = new System.Drawing.Point((int)(buttonWidth * 14.5), y2);
            this.key25.Size = new System.Drawing.Size(smallBtnWidth, smallBtnHeight);

            this.key27.Location = new System.Drawing.Point((int)(buttonWidth * 15.5), y2);
            this.key27.Size = new System.Drawing.Size(smallBtnWidth, smallBtnHeight);

            this.key31.Location = new System.Drawing.Point((int)(buttonWidth * 17.5), y2);
            this.key31.Size = new System.Drawing.Size(smallBtnWidth, smallBtnHeight);

            this.key32.Location = new System.Drawing.Point((int)(buttonWidth * 18.5), y2);
            this.key32.Size = new System.Drawing.Size(smallBtnWidth, smallBtnHeight);

            this.key34.Location = new System.Drawing.Point((int)(buttonWidth * 19.5), y2);
            this.key34.Size = new System.Drawing.Size(smallBtnWidth, smallBtnHeight);

            this.key37.Location = new System.Drawing.Point((int)(buttonWidth * 21.5), y2);
            this.key37.Size = new System.Drawing.Size(smallBtnWidth, smallBtnHeight);

            this.key39.Location = new System.Drawing.Point((int)(buttonWidth * 22.5), y2);
            this.key39.Size = new System.Drawing.Size(smallBtnWidth, smallBtnHeight);

            this.key42.Location = new System.Drawing.Point((int)(buttonWidth * 24.5), y2);
            this.key42.Size = new System.Drawing.Size(smallBtnWidth, smallBtnHeight);

            this.key44.Location = new System.Drawing.Point((int)(buttonWidth * 25.5), y2);
            this.key44.Size = new System.Drawing.Size(smallBtnWidth, smallBtnHeight);

            this.key46.Location = new System.Drawing.Point((int)(buttonWidth * 26.5), y2);
            this.key46.Size = new System.Drawing.Size(smallBtnWidth, smallBtnHeight);

            this.key49.Location = new System.Drawing.Point((int)(buttonWidth * 28.5), y2);
            this.key49.Size = new System.Drawing.Size(smallBtnWidth, smallBtnHeight);

            this.key51.Location = new System.Drawing.Point((int)(buttonWidth * 29.5), y2);
            this.key51.Size = new System.Drawing.Size(smallBtnWidth, smallBtnHeight);

            this.key54.Location = new System.Drawing.Point((int)(buttonWidth * 31.5), y2);
            this.key54.Size = new System.Drawing.Size(smallBtnWidth, smallBtnHeight);

            this.key56.Location = new System.Drawing.Point((int)(buttonWidth * 32.5), y2);
            this.key56.Size = new System.Drawing.Size(smallBtnWidth, smallBtnHeight);

            this.key58.Location = new System.Drawing.Point((int)(buttonWidth * 33.5), y2);
            this.key58.Size = new System.Drawing.Size(smallBtnWidth, smallBtnHeight);
        }

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

            this.key_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.key_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.key_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.key_5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.key_7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.key_9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.key_11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.key_12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.key_14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.key_16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.key_17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49))))); 
            this.key_19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49))))); 
            this.key_21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.key_23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.key_24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49))))); 
            this.key_26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.key_28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.key_29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.key_30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.key_33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.key_35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.key_36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.key_38.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.key_40.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.key_41.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.key_43.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.key_45.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.key_47.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.key_48.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.key_50.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.key_52.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.key_53.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.key_55.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.key_57.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.key_59.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.key_60.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
        }

        public string get_midifile(string result)
        {
            string[] files = Directory.GetFiles(@"C:\Users\rites\source\repos\NSCmusical\songfiles\");

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

            AutoClosingMessageBox.Show(files[index], "Playing", 2000);

            return files[index];
        }

        public string get_music(string final_music)
        {
            string songnotes = "";
            MidiFile midifile = MidiFile.Read(final_music);
            IEnumerable<Note> notes = midifile.GetNotes();
            var tempoMap = midifile.GetTempoMap();
            foreach (var p in notes)
            {
                long timeee = p.LengthAs<MetricTimeSpan>(tempoMap).Milliseconds;
                System.Diagnostics.Debug.WriteLine(timeee);

                //Console.WriteLine(p);
                songnotes += p.NoteNumber.ToString() + " " + p.LengthAs<MetricTimeSpan>(tempoMap).Milliseconds.ToString() + " ";
            }

            return songnotes;
        }

        public void play_music(string final_music)
        {
            var midiFile = MidiFile.Read(final_music);

            var outputDevice = OutputDevice.GetByName("Microsoft GS Wavetable Synth");

            _playback = midiFile.GetPlayback(outputDevice);

            _playback.Start();

            SpinWait.SpinUntil(() => !_playback.IsRunning);


            outputDevice.Dispose();
            _playback.Dispose();
        }

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            
            reset();
            _serialPort = new SerialPort("COM4", 9600);
            _serialPort.Open();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string result = "";
            foreach (int i in notes)
            {
                result += i.ToString() + " ";
            }

            string final_music = get_midifile(result);
            string final_notes = get_music(final_music);

            notes.Clear();

            _serialPort.Write(final_notes);
            play_music(final_music);
        }

        private void key0_Click(object sender, EventArgs e)
        {
            notes.Add(0 + 21);
            reset_color();
            this.key0.BackColor = System.Drawing.Color.Green;
            this.key_0.BackColor = System.Drawing.Color.Green;
        }

        private void key1_Click(object sender, EventArgs e)
        {
            notes.Add(1 + 21);
            reset_color();
            this.key1.BackColor = System.Drawing.Color.Green;
        }

        private void key2_Click(object sender, EventArgs e)
        {
            notes.Add(2 + 21);
            reset_color();
            this.key2.BackColor = System.Drawing.Color.Green;
            this.key_2.BackColor = System.Drawing.Color.Green;
        }

        private void key3_Click(object sender, EventArgs e)
        {
            notes.Add(3 + 21);
            reset_color();
            this.key3.BackColor = System.Drawing.Color.Green;
        }

        private void key4_Click(object sender, EventArgs e)
        {
            notes.Add(4 + 21);
            reset_color();
            this.key4.BackColor = System.Drawing.Color.Green;
            this.key_4.BackColor = System.Drawing.Color.Green;
        }

        private void key5_Click(object sender, EventArgs e)
        {
            notes.Add(5 + 21);
            reset_color();
            this.key5.BackColor = System.Drawing.Color.Green;
            this.key_5.BackColor = System.Drawing.Color.Green;
        }

        private void key6_Click(object sender, EventArgs e)
        {
            notes.Add(6 + 21);
            reset_color();
            this.key6.BackColor = System.Drawing.Color.Green;
        }

        private void key7_Click(object sender, EventArgs e)
        {
            notes.Add(7 + 21);
            reset_color();
            this.key7.BackColor = System.Drawing.Color.Green;
            this.key_7.BackColor = System.Drawing.Color.Green;
        }

        private void key8_Click(object sender, EventArgs e)
        {
            notes.Add(8 + 21);
            reset_color();
            this.key8.BackColor = System.Drawing.Color.Green;
        }

        private void key9_Click(object sender, EventArgs e)
        {
            notes.Add(9 + 21);
            reset_color();
            this.key9.BackColor = System.Drawing.Color.Green;
            this.key_9.BackColor = System.Drawing.Color.Green;
        }

        private void key10_Click(object sender, EventArgs e)
        {
            notes.Add(10 + 21);
            reset_color();
            this.key10.BackColor = System.Drawing.Color.Green;
        }

        private void key11_Click(object sender, EventArgs e)
        {
            notes.Add(11 + 21);
            reset_color();
            this.key11.BackColor = System.Drawing.Color.Green;
            this.key_11.BackColor = System.Drawing.Color.Green;
        }

        private void key12_Click(object sender, EventArgs e)
        {
            notes.Add(12 + 21);
            reset_color();
            this.key12.BackColor = System.Drawing.Color.Green;
            this.key_12.BackColor = System.Drawing.Color.Green;
        }

        private void key13_Click(object sender, EventArgs e)
        {
            notes.Add(13 + 21);
            reset_color();
            this.key13.BackColor = System.Drawing.Color.Green;
        }

        private void key14_Click(object sender, EventArgs e)
        {
            notes.Add(14 + 21);
            reset_color();
            this.key14.BackColor = System.Drawing.Color.Green;
            this.key_14.BackColor = System.Drawing.Color.Green;
        }

        private void key15_Click(object sender, EventArgs e)
        {
            notes.Add(15 + 21);
            reset_color();
            this.key15.BackColor = System.Drawing.Color.Green;
        }

        private void key16_Click(object sender, EventArgs e)
        {
            notes.Add(16 + 21);
            reset_color();
            this.key16.BackColor = System.Drawing.Color.Green;
            this.key_16.BackColor = System.Drawing.Color.Green;
        }

        private void key17_Click(object sender, EventArgs e)
        {
            notes.Add(17 + 21);
            reset_color();
            this.key17.BackColor = System.Drawing.Color.Green;
            this.key_17.BackColor = System.Drawing.Color.Green;
        }

        private void key18_Click(object sender, EventArgs e)
        {
            notes.Add(18 + 21);
            reset_color();
            this.key18.BackColor = System.Drawing.Color.Green;
        }

        private void key19_Click(object sender, EventArgs e)
        {
            notes.Add(19 + 21);
            reset_color();
            this.key19.BackColor = System.Drawing.Color.Green;
            this.key_19.BackColor = System.Drawing.Color.Green;
        }

        private void key20_Click(object sender, EventArgs e)
        {
            notes.Add(20 + 21);
            reset_color();
            this.key20.BackColor = System.Drawing.Color.Green;
        }

        private void key21_Click(object sender, EventArgs e)
        {
            notes.Add(21 + 21);
            reset_color();
            this.key21.BackColor = System.Drawing.Color.Green;
            this.key_21.BackColor = System.Drawing.Color.Green;
        }

        private void key22_Click(object sender, EventArgs e)
        {
            notes.Add(22 + 21);
            reset_color();
            this.key22.BackColor = System.Drawing.Color.Green;
        }

        private void key23_Click(object sender, EventArgs e)
        {
            notes.Add(23 + 21);
            reset_color();
            this.key23.BackColor = System.Drawing.Color.Green;
            this.key_23.BackColor = System.Drawing.Color.Green;
        }

        private void key24_Click(object sender, EventArgs e)
        {
            notes.Add(24 + 21);
            reset_color();
            this.key24.BackColor = System.Drawing.Color.Green;
            this.key_24.BackColor = System.Drawing.Color.Green;
        }

        private void key25_Click(object sender, EventArgs e)
        {
            notes.Add(25 + 21);
            reset_color();
            this.key25.BackColor = System.Drawing.Color.Green;
        }

        private void key26_Click(object sender, EventArgs e)
        {
            notes.Add(26 + 21);
            reset_color();
            this.key26.BackColor = System.Drawing.Color.Green;
            this.key_26.BackColor = System.Drawing.Color.Green;
        }

        private void key27_Click(object sender, EventArgs e)
        {
            notes.Add(27 + 21);
            reset_color();
            this.key27.BackColor = System.Drawing.Color.Green;
        }

        private void key28_Click(object sender, EventArgs e)
        {
            notes.Add(28 + 21);
            reset_color();
            this.key28.BackColor = System.Drawing.Color.Green;
            this.key_28.BackColor = System.Drawing.Color.Green;
        }

        private void key29_Click(object sender, EventArgs e)
        {
            notes.Add(29 + 21);
            reset_color();
            this.key29.BackColor = System.Drawing.Color.Green;
            this.key_29.BackColor = System.Drawing.Color.Green;
        }

        private void key30_Click(object sender, EventArgs e)
        {
            notes.Add(30 + 21);
            reset_color();
            this.key30.BackColor = System.Drawing.Color.Green;
            this.key_30.BackColor = System.Drawing.Color.Green;
        }

        private void key31_Click(object sender, EventArgs e)
        {
            notes.Add(31 + 21);
            reset_color();
            this.key31.BackColor = System.Drawing.Color.Green;
        }

        private void key32_Click(object sender, EventArgs e)
        {
            notes.Add(32 + 21);
            reset_color();
            this.key32.BackColor = System.Drawing.Color.Green;
        }

        private void key33_Click(object sender, EventArgs e)
        {
            notes.Add(33 + 21);
            reset_color();
            this.key33.BackColor = System.Drawing.Color.Green;
            this.key_33.BackColor = System.Drawing.Color.Green;
        }

        private void key34_Click(object sender, EventArgs e)
        {
            notes.Add(34 + 21);
            reset_color();
            this.key34.BackColor = System.Drawing.Color.Green;
        }

        private void key35_Click(object sender, EventArgs e)
        {
            notes.Add(35 + 21);
            reset_color();
            this.key35.BackColor = System.Drawing.Color.Green;
            this.key_35.BackColor = System.Drawing.Color.Green;
        }

        private void key36_Click(object sender, EventArgs e)
        {
            notes.Add(36 + 21);
            reset_color();
            this.key36.BackColor = System.Drawing.Color.Green;
            this.key_36.BackColor = System.Drawing.Color.Green;
        }

        private void key37_Click(object sender, EventArgs e)
        {
            notes.Add(37 + 21);
            reset_color();
            this.key37.BackColor = System.Drawing.Color.Green;
        }

        private void key38_Click(object sender, EventArgs e)
        {
            notes.Add(38 + 21);
            reset_color();
            this.key38.BackColor = System.Drawing.Color.Green;
            this.key_38.BackColor = System.Drawing.Color.Green;
        }

        private void key39_Click(object sender, EventArgs e)
        {
            notes.Add(39 + 21);
            reset_color();
            this.key39.BackColor = System.Drawing.Color.Green;
        }

        private void key40_Click(object sender, EventArgs e)
        {
            notes.Add(40 + 21);
            reset_color();
            this.key40.BackColor = System.Drawing.Color.Green;
            this.key_40.BackColor = System.Drawing.Color.Green;
        }

        private void key41_Click(object sender, EventArgs e)
        {
            notes.Add(41 + 21);
            reset_color();
            this.key41.BackColor = System.Drawing.Color.Green;
            this.key_41.BackColor = System.Drawing.Color.Green;
        }

        private void key42_Click(object sender, EventArgs e)
        {
            notes.Add(42 + 21);
            reset_color();
            this.key42.BackColor = System.Drawing.Color.Green;
        }

        private void key43_Click(object sender, EventArgs e)
        {
            notes.Add(43 + 21);
            reset_color();
            this.key43.BackColor = System.Drawing.Color.Green;
            this.key_43.BackColor = System.Drawing.Color.Green;
        }

        private void key44_Click(object sender, EventArgs e)
        {
            notes.Add(44 + 21);
            reset_color();
            this.key44.BackColor = System.Drawing.Color.Green;
        }

        private void key45_Click(object sender, EventArgs e)
        {
            notes.Add(45 + 21);
            reset_color();
            this.key45.BackColor = System.Drawing.Color.Green;
            this.key_45.BackColor = System.Drawing.Color.Green;
        }

        private void key46_Click(object sender, EventArgs e)
        {
            notes.Add(46 + 21);
            reset_color();
            this.key46.BackColor = System.Drawing.Color.Green;
        }

        private void key47_Click(object sender, EventArgs e)
        {
            notes.Add(47 + 21);
            reset_color();
            this.key47.BackColor = System.Drawing.Color.Green;
            this.key_47.BackColor = System.Drawing.Color.Green;
        }

        private void key48_Click(object sender, EventArgs e)
        {
            notes.Add(48 + 21);
            reset_color();
            this.key48.BackColor = System.Drawing.Color.Green;
            this.key_48.BackColor = System.Drawing.Color.Green;
        }

        private void key49_Click(object sender, EventArgs e)
        {
            notes.Add(49 + 21);
            reset_color();
            this.key49.BackColor = System.Drawing.Color.Green;
        }

        private void key50_Click(object sender, EventArgs e)
        {
            notes.Add(50 + 21);
            reset_color();
            this.key50.BackColor = System.Drawing.Color.Green;
            this.key_50.BackColor = System.Drawing.Color.Green;
        }

        private void key51_Click(object sender, EventArgs e)
        {
            notes.Add(51 + 21);
            reset_color();
            this.key51.BackColor = System.Drawing.Color.Green;
        }

        private void key52_Click(object sender, EventArgs e)
        {
            notes.Add(52 + 21);
            reset_color();
            this.key52.BackColor = System.Drawing.Color.Green;
            this.key_52.BackColor = System.Drawing.Color.Green;
        }

        private void key53_Click(object sender, EventArgs e)
        {
            notes.Add(53 + 21);
            reset_color();
            this.key53.BackColor = System.Drawing.Color.Green;
            this.key_53.BackColor = System.Drawing.Color.Green;
        }

        private void key54_Click(object sender, EventArgs e)
        {
            notes.Add(54 + 21);
            reset_color();
            this.key54.BackColor = System.Drawing.Color.Green;
        }

        private void key55_Click(object sender, EventArgs e)
        {
            notes.Add(55 + 21);
            reset_color();
            this.key55.BackColor = System.Drawing.Color.Green;
            this.key_55.BackColor = System.Drawing.Color.Green;
        }

        private void key56_Click(object sender, EventArgs e)
        {
            notes.Add(56 + 21);
            reset_color();
            this.key56.BackColor = System.Drawing.Color.Green;
        }

        private void key57_Click(object sender, EventArgs e)
        {
            notes.Add(57 + 21);
            reset_color();
            this.key57.BackColor = System.Drawing.Color.Green;
            this.key_57.BackColor = System.Drawing.Color.Green;
        }

        private void key58_Click(object sender, EventArgs e)
        {
            notes.Add(58 + 21);
            reset_color();
            this.key58.BackColor = System.Drawing.Color.Green;
        }

        private void key59_Click(object sender, EventArgs e)
        {
            notes.Add(59 + 21);
            reset_color();
            this.key59.BackColor = System.Drawing.Color.Green;
            this.key_59.BackColor = System.Drawing.Color.Green;
        }

        private void key60_Click(object sender, EventArgs e)
        {
            notes.Add(60 + 21);
            reset_color();
            this.key60.BackColor = System.Drawing.Color.Green;
            this.key_60.BackColor = System.Drawing.Color.Green;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
