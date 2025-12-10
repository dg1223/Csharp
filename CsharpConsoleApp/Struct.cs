using System;

struct Rectangle
{
    private int m_width;
    private int m_height;

    public int Width
    {
        get
        {
            return m_width;
        }

        set
        {
            m_width = value;
        }
    }

    public int Height
    {
        get
        {
            return m_height;
        }

        set
        {
            m_height = value;
        }
    }
}

class StructExample
{
    static void Main()
    {
        Rectangle rect = new Rectangle();
        rect.Width = 1;
        rect.Height = 3;

        Console.WriteLine("rect1: {0}, {1}", rect.Width, rect.Height);
    }
}