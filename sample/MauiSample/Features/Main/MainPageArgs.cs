﻿namespace MauiSample.Features.Main;

public class MainPageArgs
{
    public int InitialCounter { get; }

    public MainPageArgs(int initialCounter) =>
        InitialCounter = initialCounter;
}