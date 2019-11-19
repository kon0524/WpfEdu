using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfEdu.ViewModels;

namespace WpfEdu
{
	/// <summary>
	/// ボタンを押したときのコマンド
	/// </summary>
	class PushCommand : ICommand
	{
		private MainWindowViewModel vm;

		public PushCommand(MainWindowViewModel vm)
		{
			this.vm = vm;
		}

		public event EventHandler CanExecuteChanged;

		public bool CanExecute(object parameter)
		{
			return true;
		}

		public void Execute(object parameter)
		{
			vm.MyText = "こんにちわ世界";
		}
	}
}
