using Prism.Commands;
using Prism.Mvvm;
using WpfEdu.Models;
using Prism.Unity;
using Unity;

namespace WpfEdu.ViewModels
{
	class MainWindowViewModel : BindableBase
	{
		private MessageProvider messageProvider;

		/// <summary>
		/// コンストラクタ
		/// </summary>
		public MainWindowViewModel(MessageProvider messageProvider)
		{
			// Model
			this.messageProvider = messageProvider;

			// 初期値を設定
			//MyText = "Hello World";
			MyText = this.messageProvider.MsgEnglish;
			PushCommand = new DelegateCommand(() =>
			{
				MyText = this.messageProvider.MsgJapanese;
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
