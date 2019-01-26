﻿
namespace WordByWord.Services
{
    public interface IWindowService
    {
        void ShowWindow(string window, ViewModel.ViewModel viewModel);
        void CloseWindow(string window);
    }

    public class WindowService : IWindowService
    {
        private Editor _editor;
        private Library _library;
        private Reader _reader;
        private InputText _inputText;
        private Info _info;

        public void ShowWindow(string window, ViewModel.ViewModel viewModel)
        {
            switch (window)
            {
                case "Editor":
                    _editor = new Editor(viewModel);
                    _editor.ShowDialog();
                    break;
                case "Library":
                    if (_library == null)
                    {
                        _library = new Library();
                    }
                    _library.Show();
                    break;
                case "Reader":
                    _reader = new Reader(viewModel);
                    _reader.ShowDialog();
                    break;
                case "InputText":
                    _inputText = new InputText(viewModel);
                    _inputText.ShowDialog();
                    break;
                case "Info":
                    _info = new Info();
                    _info.ShowDialog();
                    break;
            }
        }

        public void CloseWindow(string window)
        {
            switch (window)
            {
                case "Editor":
                    _editor?.Close();
                    _editor = null;
                    break;
                case "Library":
                    _library?.Hide();
                    break;
                case "Reader":
                    _reader?.Close();
                    _reader = null;
                    break;
                case "InputText":
                    _inputText?.Close();
                    _inputText = null;
                    break;
                case "Info":
                    _info?.Close();
                    _info = null;
                    break;
            }
        }
    }
}
