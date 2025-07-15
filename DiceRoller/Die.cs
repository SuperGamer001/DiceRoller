namespace DiceRoller;

/// <summary>
/// Represents a customizable die.
/// </summary>
/// <remarks>This class can be used to simulate a custom die in games or simulations. The number of sides can be set to
/// any positive byte value (1-20 inclusive).</remarks>
public class Die
{
    private const byte MAX_SIZE = 20;

    // Private Variables
    private static readonly Random rand = new();


    /// <summary>
    /// Creates a new instance of the <see cref="Die"/> class with a specified number of sides.
    /// </summary>
    /// <param name="numSides">
    /// The number of sides (or faces) on the die. Must be between 1 and 20 inclusive.
    /// </param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// Thrown when <paramref name="numSides"/> is less than 1 or greater than 20.
    /// </exception>
    public Die(byte numSides = 6, Boolean auto_roll = false)
    {
        if (numSides < 1 || numSides > MAX_SIZE)
        {
            throw new ArgumentOutOfRangeException(nameof(numSides), "The number of sides must be between 1 and 20.");
        }
        this.NumberOfSides = numSides;

        if (auto_roll)
        {
            Roll();
        }
    }
    public byte NumberOfSides { get; private set; }

    /// <summary>
    /// The current face-up value of the die.
    /// This property defaults to null until the die is rolled.
    /// </summary>
    public byte? FaceUpValue { get; private set; }

    /// <summary>
    /// Rolls the die and returns the face-up value.
    /// </summary>
    /// <returns>The face-up value of the die after rolling.</returns>
    public byte Roll()
    {
        // Generate a random number between 1 and NumberOfSides (inclusive)
        // Note: (byte) is like Convert.ToByte() but more efficient
        FaceUpValue = (byte)rand.Next(1, NumberOfSides + 1);

        return (byte)FaceUpValue;
    }
}
