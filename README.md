# Unexpected Operator Behavior with Implicit Conversion Operators in C#

This example demonstrates a subtle issue that can arise when using implicit conversion operators in C#.  While implicit conversions allow for seamless type changes, they don't automatically overload all operators.

The code defines implicit conversions between a custom class `MyClass` and the `int` type.  Although implicit conversion works for assignment, it fails when attempting to use the `+` operator directly with `MyClass` and `int`.

## Problem
The program attempts to add an integer to a `MyClass` object, which results in a compiler error.  This is because the `+` operator isn't automatically overloaded to handle the implicit conversions.

## Solution
To address this, you need to explicitly overload the `+` operator within the `MyClass` class to handle addition with integers.