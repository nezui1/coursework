namespace courseWorkList;

public class DrawningState
{
    private PictureBox pictureBox;



    public DrawningState(PictureBox pictureBox)
    {
        this.pictureBox = pictureBox;
    }

    public void Visualize(StateClass state)
    {
        Bitmap bitmap = new(pictureBox.Width, pictureBox.Height);
        if (state != null)
        {
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.Clear(Color.White);
                DrawState(g, state);
            }
        }
        pictureBox.Image = bitmap;
    }

    public void Clear()
    {
        pictureBox.Image = null;
    }

    private void DrawState(Graphics g, StateClass state)
    {
        int posX = 10;

        int posY = 22;

        Node current = state.List.head;

        int n = 0;

        Pen pen = new Pen(Color.Black);
        Brush brush = new SolidBrush(Color.Black);

        if (state.Highlighted == -1)
        {
            MessageBox.Show("Элемента не нашлось");
        }
        while (current != null)
        {
            if (state.Highlighted != null && n == state.Highlighted)
            {
                g.DrawEllipse(new Pen(Color.Red), posX, posY, 50, 50);
                if (state.Highlighted == state.Searched)
                {
                    MessageBox.Show("Объект найден!");
                }
            }
            else
            {
                g.DrawEllipse(pen, posX, posY, 50, 50);
            }

            g.DrawString(current.Value.ToString(), new Font("Arial", 10), Brushes.Black, posX + 50 / 2, posY + 50 / 2);

            if (posX + 100 < pictureBox.Width)
            {
                posX += 50;
                current = current.Next;
            }

            else
            {
                posX = 10;
                current = current.Next;

                posY += 50;
            }
            n++;
        }
    }

}
