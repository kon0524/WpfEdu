using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfEdu;

namespace WpfEdu.ViewModels
{
	class MainWindowViewModel : INotifyPropertyChanged
	{
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public MainWindowViewModel()
		{
			// 初期値を設定
			MyText = "Hello World";
			PushCommand = new PushCommand(this);
		}

		/// <summary>
		/// テキストボックスに表示する文字列
		/// </summary>
		private string myText;
		public string MyText
		{
			get { return this.myText; }
			set
			{
				this.myText = value;
				NotifyPropertyChanged();
			}
		}

		/// <summary>
		/// ボタン押下のコマンド
		/// </summary>
		public ICommand PushCommand { get; private set; }

		public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
		/// 値が変更されたことをViewへ通知する
		/// </summary>
		/// <param name="propertyName"></param>
		private void NotifyPropertyChanged([CallerMemberName]string propertyName = null)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
