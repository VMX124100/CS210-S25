using System;
public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {

    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetDisplayText()
    {
    
    }
}