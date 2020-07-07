using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> colectedFragments = new Dictionary<string, int>();
            colectedFragments.Add("shards", 0);
            colectedFragments.Add("fragments", 0);
            colectedFragments.Add("motes", 0);

            Dictionary<string, int> trash = new Dictionary<string, int>();

            bool isTrue = false;
            string materialName = "";

            while (true)
            {
                List<string> fragments = Console.ReadLine()
                    .ToLower()
                    .Split()
                    .ToList();

                AddMaterialForWeapon(fragments, colectedFragments, trash);

                foreach (var item in colectedFragments)
                {
                    if (item.Value >= 250)
                    {
                        materialName = item.Key;
                        isTrue = true;
                    }
                }
               
                if (isTrue)
                {
                    break;
                }
            }

            switch (materialName)
            {
                case "shards":
                    Console.WriteLine($"Shadowmourne obtained!");
                    break;
                case "fragments":
                    Console.WriteLine($"Valanyr obtained!");
                    break;
                case "motes":
                    Console.WriteLine($"Dragonwrath obtained!");
                    break;
            }
            colectedFragments[materialName] -= 250;
            colectedFragments.OrderByDescending(x => x.Value);

            foreach (var item in colectedFragments.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            foreach (var item in trash.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
        private static void AddMaterialForWeapon(List<string> fragments, Dictionary<string, int> colecteddFragments, Dictionary<string, int> trash)
        {
            int quantity = 0;
            string materials = "";
            for (int i = 0; i < fragments.Count; i++)
            {
                if (i % 2 == 0)
                {
                    quantity = int.Parse(fragments[i]);
                }
                else
                {
                    materials = fragments[i];

                    if (materials == "motes" || materials == "fragments" || materials == "shards")
                    {
                        if (colecteddFragments.ContainsKey(materials) == false)
                        {
                            colecteddFragments.Add(materials, 0);
                        }
                        colecteddFragments[materials] += quantity;
                        if (colecteddFragments[materials] >= 250)
                        {
                            break;
                        }
                    }
                    else
                    {
                        if (trash.ContainsKey(materials) == false)
                        {
                            trash.Add(materials, 0);
                        }
                        trash[materials] += quantity;
                    }
                }
            }
        }
    }
}
