// Get depths
string[] depthsString = System.IO.File.ReadAllLines(@"Input.txt");

// Convert to ints
List<int> depths = new();
for (int i = 0; i < depthsString.Length; i++)
{
    depths.Add(int.Parse(depthsString[i]));
}

// Init counter
int deeper = 0;

// Calculate first tripple
int previousTrippel = depths[0] + depths[1] + depths[2];
int currentTrippel;


// Compare previous tripple to next trippel and if smaller add to deeper counter
for (int i = 1; i < depths.Count-2; i++)
{
    currentTrippel= depths[i] + depths[i+1] + depths[i+2];

    if (currentTrippel>previousTrippel)
    {
        deeper++;
    }
    previousTrippel = currentTrippel;
}

// print result
Console.WriteLine(deeper);
