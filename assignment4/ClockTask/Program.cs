using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace ClockTask {
	public class TikTokEventArgs {
		public int time { get; set; }	
	}
	public delegate void TikTokHandler(object sender, TikTokEventArgs args);
	
	public class AlarmEventArgs {
		public int alarmTime { get; set; }
	}
	public delegate void AlarmHandler(object sender, AlarmEventArgs args);

	public class Clock {
		public event TikTokHandler Tiking;
		public event AlarmHandler Alarming;
		
		private int time;
		public int alarmTime { get; set; }
		private Thread thread;

		public Clock() {
			time = 0;
			thread = new Thread(Run);
			thread.Start();
		}

		private void Run() {
			while (true) {
				Thread.Sleep(1000);
				time++;
				TikTokEventArgs tiktokArgs = new TikTokEventArgs() {
					time = this.time
				};
				Tiking(this, tiktokArgs);
				if (time == alarmTime) {
					AlarmEventArgs alarmArgs = new AlarmEventArgs() {
						alarmTime = this.alarmTime
					};
					Alarming(this, alarmArgs);
				}
			}
		}
	}

	public class Program {
		static public void ListenTiktok(object sender, TikTokEventArgs args) {
			Console.WriteLine($"Tiktok at {args.time}");
		}
		static public void ListenAlarm(object sender, AlarmEventArgs args) {
			Console.WriteLine($"Alarming!!!!!! now is {args.alarmTime}");
		}
		static public void Main(string[] s) {
			Clock clock = new Clock();
			clock.alarmTime = 10;
			clock.Tiking += ListenTiktok;
			clock.Alarming += ListenAlarm;
			while (true) {
				
			}
			return;
		}
	}
}
