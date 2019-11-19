using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfEdu;
using Prism.Mvvm;
using Prism.Commands;

namespace WpfEdu.ViewModels
{
	class MainWindowViewModel : BindableBase
	{
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public MainWindowViewModel()
		{
			// 初期値を設定
			MyText = "Hello World";
			PushCommand = new DelegateCommand(() =>
			{
				MyText = "こんにちわ世界";
			});
		}

		/// <summary>
		/// テキストボックスに表示する文字列
		/// </summary>
		private string myText;
		public string MyText
		{
			get { return this.myText; }
			set { this.SetProperty(ref this.myText, value); }
		}

		/// <summary>
		/// ボタン押下のコマンド
		/// </summary>
		public DelegateCommand PushCommand { get; private set; }
	}
}
