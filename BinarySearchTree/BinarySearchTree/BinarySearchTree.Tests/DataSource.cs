using BookClass;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TimeStruct;
using TimeStruct.TimeStruct;

namespace BinarySearchTree.Tests
{
    public sealed class DataSource
    {
        public static IEnumerable<TestCaseData> TestCasesString
        {
            get
            {
                yield return new TestCaseData(new string[] { "12", "Zero", "Test", "Hello" }, new[] { "12", "Zero", "Test", "Hello" },
                    new[] { "12", "Hello", "Test", "Zero" }, new[] {"Hello", "Test", "Zero", "12" }, null);
                yield return new TestCaseData(new string[] { "12", "Zero", "Test", "Hello" }, new[] { "12", "Zero", "Test", "Hello" },
                    new[] { "12", "Hello", "Test", "Zero" }, new[] { "Hello", "Test", "Zero", "12" }, new StringComparer());
            }
        }

        public static IEnumerable<TestCaseData> TestCasesInt32
        {
            get
            {
                yield return new TestCaseData(new int[] { 8, 3, 1, 6, 4, 7, 10, 14 }, new[] { 8, 3, 1, 6, 4, 7, 10, 14 }, new[] { 1, 3, 4, 6, 7, 8, 10, 14 },
                    new[] { 1, 4, 7, 6, 3, 14, 10, 8 }, null);
                yield return new TestCaseData(new int[] { 8, 3, 1, 6, 4, 7, 10, 14 }, new[] { 8, 3, 1, 6, 4, 7, 10, 14 }, new[] { 1, 3, 4, 6, 7, 8, 10, 14 },
                    new[] { 1, 4, 7, 6, 3, 14, 10, 8 }, new IntComparer());
            }
        }

        public static IEnumerable<TestCaseData> TestCasesBookWithoutComparer
        {
            get
            {
                yield return new TestCaseData(
                    new Book[]
                    {
                        new Book(null, "19asfas84", "Secker and Warburg","000000000000"),
                        new Book("ABCDEFG", "fas1984", "Secker and Warburg", "000000000001"),
                        new Book(null, "19asfas84", "Secker and Warburg", "000000000002"),
                        new Book("Nikita", "198asf4", "Secker and Warburg", "000000000003"),
                        new Book("Nikita", "198asf4", "Secker and Warburg", "000000000004"),
                        new Book("Джорджа Оруэлла", "19das84", "Secker and Warburg", "000000000005"),
                        new Book("Sidorenko", "1safas984", "Secker and Warburg", "000000000006")
                    },
                    new Book[]
                    {
                        new Book(null, "19asfas84", "Secker and Warburg","000000000000"),
                        new Book("Nikita", "198asf4", "Secker and Warburg", "000000000003"),
                        new Book("Nikita", "198asf4", "Secker and Warburg", "000000000004"),
                        new Book("ABCDEFG", "fas1984", "Secker and Warburg", "000000000001"),
                        new Book(null, "19asfas84", "Secker and Warburg", "000000000002"),
                        new Book("Джорджа Оруэлла", "19das84", "Secker and Warburg", "000000000005"),
                        new Book("Sidorenko", "1safas984", "Secker and Warburg", "000000000006")
                    },
                    new Book[]
                    {
                        new Book("Nikita", "198asf4", "Secker and Warburg", "000000000003"),
                        new Book("Nikita", "198asf4", "Secker and Warburg", "000000000004"),
                        new Book(null, "19asfas84", "Secker and Warburg","000000000000"),
                        new Book(null, "19asfas84", "Secker and Warburg", "000000000002"),
                        new Book("Джорджа Оруэлла", "19das84", "Secker and Warburg", "000000000005"),
                        new Book("Sidorenko", "1safas984", "Secker and Warburg", "000000000006"),
                        new Book("ABCDEFG", "fas1984", "Secker and Warburg", "000000000001")
                    },
                    new Book[]
                    {
                        new Book("Nikita", "198asf4", "Secker and Warburg", "000000000004"),
                        new Book("Nikita", "198asf4", "Secker and Warburg", "000000000003"),
                        new Book("Sidorenko", "1safas984", "Secker and Warburg", "000000000006"),
                        new Book("Джорджа Оруэлла", "19das84", "Secker and Warburg", "000000000005"),
                        new Book(null, "19asfas84", "Secker and Warburg", "000000000002"),
                        new Book("ABCDEFG", "fas1984", "Secker and Warburg", "000000000001"),
                        new Book(null, "19asfas84", "Secker and Warburg","000000000000")
                    });
            }
        }

        public static IEnumerable<TestCaseData> TestCasesBookWithComparer
        {
            get
            {
                yield return new TestCaseData(
                    new Book[]
                    {
                        new Book(null, "19asfas84", "Secker and Warburg","000000000000"),
                        new Book("ABCDEFG", "fas1984", "Secker and Warburg", "000000000001"),
                        new Book(null, "19asfas84", "Secker and Warburg", "000000000002"),
                        new Book("Nikita", "198asf4", "Secker and Warburg", "000000000003"),
                        new Book("Nikita", "198asf4", "Secker and Warburg", "000000000004"),
                        new Book("Джорджа Оруэлла", "19das84", "Secker and Warburg", "000000000005"),
                        new Book("Sidorenko", "1safas984", "Secker and Warburg", "000000000006")
                    },
                    new Book[]
                    {
                        new Book(null, "19asfas84", "Secker and Warburg","000000000000"),
                        new Book("ABCDEFG", "fas1984", "Secker and Warburg", "000000000001"),
                        new Book(null, "19asfas84", "Secker and Warburg", "000000000002"),
                        new Book("Nikita", "198asf4", "Secker and Warburg", "000000000003"),
                        new Book("Nikita", "198asf4", "Secker and Warburg", "000000000004"),
                        new Book("Джорджа Оруэлла", "19das84", "Secker and Warburg", "000000000005"),
                        new Book("Sidorenko", "1safas984", "Secker and Warburg", "000000000006")
                    },
                    new Book[]
                    {
                        new Book(null, "19asfas84", "Secker and Warburg","000000000000"),
                        new Book(null, "19asfas84", "Secker and Warburg", "000000000002"),
                        new Book("ABCDEFG", "fas1984", "Secker and Warburg", "000000000001"),
                        new Book("Nikita", "198asf4", "Secker and Warburg", "000000000003"),
                        new Book("Nikita", "198asf4", "Secker and Warburg", "000000000004"),
                        new Book("Sidorenko", "1safas984", "Secker and Warburg", "000000000006"),
                        new Book("Джорджа Оруэлла", "19das84", "Secker and Warburg", "000000000005")
                    },
                    new Book[]
                    {
                        new Book(null, "19asfas84", "Secker and Warburg", "000000000002"),
                        new Book("Sidorenko", "1safas984", "Secker and Warburg", "000000000006"),
                        new Book("Джорджа Оруэлла", "19das84", "Secker and Warburg", "000000000005"),
                        new Book("Nikita", "198asf4", "Secker and Warburg", "000000000004"),
                        new Book("Nikita", "198asf4", "Secker and Warburg", "000000000003"),
                        new Book("ABCDEFG", "fas1984", "Secker and Warburg", "000000000001"),
                        new Book(null, "19asfas84", "Secker and Warburg","000000000000")
                    },
                new BookAuthorComparer());
            }
        }
        public static IEnumerable<TestCaseData> TestCasesTimeStruct
        {
            get
            {
                yield return new TestCaseData(
                    new Time[]
                    {
                        new Time(32, 3124),     
                        new Time(15120, 123),
                        new Time(-10, 3),
                        new Time(10, -3),
                        new Time(140, -5123)
                    },
                    new Time[]
                    {
                        new Time(32, 3124),
                        new Time(15120, 123),
                        new Time(10, -3),
                        new Time(140, -5123),
                        new Time(-10, 3)
                    }, 
                    new Time[]
                    {
                        new Time(15120, 123),
                        new Time(140, -5123),
                        new Time(10, -3),
                        new Time(32, 3124),
                        new Time(-10, 3)
                    },
                    new Time[]
                    {
                        new Time(140, -5123),
                        new Time(10, -3),
                        new Time(15120, 123),
                        new Time(-10, 3),
                        new Time(32, 3124)
                    },
                new TimeComparer());
            }
        }
    }
}

