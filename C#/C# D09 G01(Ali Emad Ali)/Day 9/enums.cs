using System;

enum Weekdays
{
    Monday = 1,
    Tuesday = 2,
    Wednesday = 3,
    Thursday = 4,
    Friday = 5,
    Saturday = 6,
    Sunday = 7
}

enum Grades : short
{
    F = -1,
    D = 0,
    C = 1,
    B = 2,
    A = 3
}

enum GenderDefault : int // (4 bytes)
{
    Male,
    Female,
    Engineer
}

enum GenderByte : byte // (1 byte)
{
    Male,
    Female,
    Engineer
}