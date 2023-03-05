namespace Activator.View
{
    internal class Helper
    {
        internal static void ComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;

            if (comboBox is not null)
            {
                if (comboBox.Enabled)
                {
                    e.DrawBackground();
                }

                if (e.Index >= 0)
                {
                    Color color = e.ForeColor;

                    if (!comboBox.Enabled)
                    {
                        color = SystemColors.GrayText;
                    }

                    TextRenderer.DrawText(e.Graphics, comboBox.Items[e.Index].ToString(), e.Font, e.Bounds, color, TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter);
                }

                if (comboBox.Enabled)
                {
                    e.DrawFocusRectangle();
                }
            }
        }
    }
}
