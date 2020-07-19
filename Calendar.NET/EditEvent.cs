using System;
using System.Globalization;
using System.Windows.Forms;

namespace Calendar.NET
{
    internal partial class EditEvent : Form
    {
        private IEvent _event;
        private IEvent _newEvent;

        public IEvent Event
        {
            get { return _event; }
            set
            {
                _event = value;
                FillValues();
            }
        }

        public IEvent NewEvent
        {
            get { return _newEvent; }
        }

        public EditEvent()
        {
            InitializeComponent();
        }

        private void FillValues()
        {
            txtEventName.Text = _event.EventText;
            pnlEventColor.BackColor = _event.EventColor;
            pnlTextColor.BackColor = _event.EventTextColor;

            Text = char.ToUpper(_event.EventText[0]) + _event.EventText.Substring(1) + " Details";

            _newEvent = _event.Clone();
        }

        private void BtnOkClick(object sender, EventArgs e)
        {
            _event.EventText = txtEventName.Text;
            _event.EventTextColor = _newEvent.EventTextColor;
            _event.EventColor = _newEvent.EventColor;
            DialogResult = DialogResult.OK;
            
            Close();
        }

        private void PnlEventColorDoubleClick(object sender, EventArgs e)
        {
            colorDialog1.Color = _newEvent.EventColor;
            
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pnlEventColor.BackColor = colorDialog1.Color;
                _newEvent.EventColor = colorDialog1.Color;
            }
        }

        private void PnlTextColorDoubleClick(object sender, EventArgs e)
        {
            colorDialog1.Color = _event.EventColor;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pnlTextColor.BackColor = colorDialog1.Color;
                _newEvent.EventTextColor = colorDialog1.Color;
            }
        }

        private void BtnCancelClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

    }
}
