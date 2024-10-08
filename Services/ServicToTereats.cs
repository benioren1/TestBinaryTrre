﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TestFinalFirstWeek.Services
{
    public class ServicToTereats
    {
        //O(1)
        //מילון ששומר טווחים של סוגי מטרות לתקיפה
        public Dictionary<string, int> targets = new Dictionary<string, int>()
            {
                {"Web Server" ,10 },
                {"Database" , 15 },
                {"User Credentials" , 20 },
            };
        //O(1)
        //פונקציה שמטעינה את הגייסון של ההתקפות
        public List<ThreatsNode> LoeadJsonForTereats()
        {
            string filePath2 = @"C:\testTrre\TestFinalFirstWeek\tereats.json";

            string jsonString2 = File.ReadAllText(filePath2);
         
            List<ThreatsNode> trees2 = JsonSerializer.Deserialize<List<ThreatsNode>>(jsonString2);
            if (trees2 != null)
            {
                return trees2;
            }
            else
            {
                return new List<ThreatsNode>();
            }
        }
        //O(1)
        //פונקציה שמחזירה את הטווח של החומרה
        public int Getseverity(ThreatsNode node)
        {
            int TargetValue = GetTarget(node.ThreatType);
            int severity = (node.Volume * node.Sophistication) + TargetValue;
            return severity;
        }

        //פונקציה שבודקת במילון האם קיים ערך כזה
        public int GetTarget(string target)
        {
            bool keyExists = targets.ContainsKey(target);
            if (keyExists)
            {
                return targets[target];
            }
            else
            {
                return 5;
            }
        }

        //O(n(log)n)
        //פונקציה שמקבלת ליסט של התקפות ועץ ומפעילה התקפות ומחפשת הגנות בעץ
        public void StartAtaack(List<ThreatsNode> list,BinaryTree binaryTree)
        {
            if (list != null)
            { 
                foreach (ThreatsNode node in list)
                {
                    binaryTree.Find(node.ThreatType, Getseverity(node));
                }
            }
        }
        //O(1)
        //פונקציה שמדפיסה לי אם נמצא התאמה להגנה או לא
        public void printstatus(Node? node , string? name)
        {

            if (node == null && name == null)
            {
                Console.WriteLine("was defence suitable No!found. Brace for impact");
            }

            if (node != null && name != null)
            {
                Thread.Sleep(2000);
                Console.WriteLine($"Attck: {name}  [{node.MinSeverity}-{node.MaxSeverity}] defense: {node.Defenses[0]} ");
                Thread.Sleep(2000);
                Console.WriteLine($"Attck: {name}  [{node.MinSeverity}-{node.MaxSeverity}] defense: {node.Defenses[1]} ");
                Console.WriteLine();
            }
        }

    }
}
