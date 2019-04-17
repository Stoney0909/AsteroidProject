using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_ONe.Content.Players
{
    class PlayerUpgrades
    {
        int health;
        int damage;
        float maxVel;
        int coolDown;
        public bool playerUpgraded;
        
        public void Upgrade(Player player)
        {
            if (playerUpgraded)
            {
                player.health = health;
                player.damage = damage;
                player.maxVel = maxVel;
                player.coolDown = coolDown;
            }
        }
        public void playerCopy(Player player)
        {
            health = player.health;
            damage = player.damage;
            maxVel = player.maxVel;
            coolDown = player.coolDown;
            CU Form1 = new CU(health, damage, maxVel, coolDown);
            Form1.ShowDialog();

        }
            
    }
}
