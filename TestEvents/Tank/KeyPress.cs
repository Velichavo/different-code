using System;
using System.Collections.Generic;
using System.Text;

namespace TestEvents.Tank
{
    public class KeyPress
    {
        public event EventHandler<KeyPressedArgs> KeyPressed;
        private void OnKeyPressed(object sender, KeyPressedArgs e)
        {
            KeyPressed?.Invoke(sender, e);
        }

        public void Update()
        {
            OnKeyPressed(this, new KeyPressedArgs(Console.ReadKey(true).KeyChar));
        }
    }

    public class KeyPressedArgs : EventArgs
    {
        public KeyPressedArgs(char key)
        {
            Key = key;
        }

        public char Key { get; }
    }
}
