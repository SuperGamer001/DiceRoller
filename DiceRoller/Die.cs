namespace DiceRoller;

/// <summary>
/// Represents a customizable die.
/// </summary>
/// <remarks>This class can be used to simulate a custom die in games or simulations. The number of sides can be set to
/// any positive byte value (1-255 inclusive).</remarks>
public class Die
{
    public Die(byte numSides)
    {
        if (numSides < 1 || numSides > 20)
        {
            throw new ArgumentOutOfRangeException(nameof(numSides), "The number of sides must be between 1 and 20.");
        }
        this.numSides = numSides;
    }
    public byte numSides { get; private set; }
}
