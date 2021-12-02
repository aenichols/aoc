using System;
using System.Collections.Generic;
using aoc.day.two;
using aoc.inputs.one;

Console.WriteLine("Hello World");
var inputs = new AOC1_Inputee();
aoc_day1_pt1(inputs.day_one_test);
aoc_day1_pt1(inputs.day_one);

aoc_day1_pt2(inputs.day_one_test);
aoc_day1_pt2(inputs.day_one);

aoc_day2_pt1(AOC2_Inputee.Day_two_test);
aoc_day2_pt1(AOC2_Inputee.Day_two);

aoc_day2_pt2(AOC2_Inputee.Day_two_test);
aoc_day2_pt2(AOC2_Inputee.Day_two);

// *
static void aoc_day1_pt1(List<int> inputs)
{
  int c = 0;
  for(int i = 0; i < inputs.Count - 1; ++i) {

    c += Convert.ToInt16(inputs[i] < inputs[i + 1]) * 1;
  }

  System.Console.WriteLine($"Your answer is: {c} - brought to you by the branchless .net! tm");
}

static void aoc_day1_pt2(List<int> inputs)
{
  int c = 0;
  int prev = inputs[0];
  for(int i = 3; i < inputs.Count; ++i) {

    c += Convert.ToInt16(prev < inputs[i]) * 1;

    prev = inputs[i - 2];
  }

  System.Console.WriteLine($"Your answer is: {c} - brought to you by the branchless .net! tm");
}

// *
static void aoc_day2_pt1(List<Input> inputs)
{
  var sub = new Submarine();

  inputs.ForEach(c => {
      sub.CommandSub(c.Command, c.Inc);
  });

  var result = sub.GetPosition();

  System.Console.WriteLine($"Your answer is- depth:{result.depth}  horizontal:{result.horizontal} overall:{result.depth * result.horizontal} - brought to you by the branchless .net! tm");
}

static void aoc_day2_pt2(List<Input> inputs)
{
  var sub = new Submarine();

  inputs.ForEach(c => {
      sub.CommandSub_two(c.Command, c.Inc);
  });

  var result = sub.GetPosition();

  System.Console.WriteLine($"Your answer is- depth:{result.depth}  horizontal:{result.horizontal} overall:{result.depth * result.horizontal} - brought to you by the branchless .net! tm");
}
