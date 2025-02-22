﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Руководство
{
    public partial class Калькулятор : Form
    {
        Database database = new Database();
        private CharacterRepository characterRepository;
        public Калькулятор()
        {
            InitializeComponent();
            characterRepository = new CharacterRepository(database);
        }
        private string[] setChar(string nameCharacter)
        {
            DataTable characterInfoTable = characterRepository.GetCharacterInfo(nameCharacter);
            DataTable characterAbilityLevelUpTable = characterRepository.GetCharacterAbilityLevelUpResources(nameCharacter);
            DataTable characterLevelUpTable = characterRepository.GetCharacterLevelUpResources(nameCharacter);

            // Рес-сы для талантов
            List<string> imagePaths_abil_lvlup = new List<string>();
            foreach (DataRow row in characterAbilityLevelUpTable.Rows)
            {
                imagePaths_abil_lvlup.Add(row["name_resource"].ToString());
            }
            // Рес-сы для возвышения
            List<string> imagePaths_char_lvlup = new List<string>();
            foreach (DataRow row in characterLevelUpTable.Rows)
            {
                imagePaths_char_lvlup.Add(row["name_resource"].ToString());
            }
            return new string[] { characterInfoTable.Rows[0]["name"].ToString(), characterInfoTable.Rows[0]["image"].ToString(), imagePaths_abil_lvlup[0], imagePaths_abil_lvlup[1], imagePaths_abil_lvlup[2], imagePaths_abil_lvlup[3], imagePaths_abil_lvlup[4], imagePaths_abil_lvlup[5], imagePaths_abil_lvlup[6], imagePaths_char_lvlup[3], imagePaths_char_lvlup[4], imagePaths_char_lvlup[5], imagePaths_char_lvlup[6], imagePaths_char_lvlup[7], imagePaths_char_lvlup[8] };
        }
        private int[] selectLVL(int lvl1, int lvl2)
        {
            DataTable lvlTable = characterRepository.GetLevelData(lvl1, lvl2);

            if (lvl1 != lvl2)
            {
                return new int[] { Convert.ToInt32(lvlTable.Rows[0]["Total_EXP"]), Convert.ToInt32(lvlTable.Rows[1]["Total_EXP"]), Convert.ToInt32(lvlTable.Rows[0]["mora"]), Convert.ToInt32(lvlTable.Rows[1]["mora"]) };
            }
            else
            {
                return new int[] { Convert.ToInt32(lvlTable.Rows[0]["Total_EXP"]), Convert.ToInt32(lvlTable.Rows[0]["Total_EXP"]), 0, 0 };
            }
        }
        private int[] selectTalent_LVL(int tal1, int tal2)
        {
            DataTable talantLvlTable = characterRepository.GetTalentLevelData(tal1, tal2);

            if (tal1 != tal2)
            {
                int total_tal_book1 = Convert.ToInt32(talantLvlTable.Rows[0]["total_tal_book1"]);
                int total_tal_book2 = Convert.ToInt32(talantLvlTable.Rows[0]["total_tal_book2"]);
                int total_tal_book3 = Convert.ToInt32(talantLvlTable.Rows[0]["total_tal_book3"]);
                int total_tal_res1 = Convert.ToInt32(talantLvlTable.Rows[0]["total_tal_res1"]);
                int total_tal_res2 = Convert.ToInt32(talantLvlTable.Rows[0]["total_tal_res2"]);
                int total_tal_res3 = Convert.ToInt32(talantLvlTable.Rows[0]["total_tal_res3"]);
                int total_weekly_boss = Convert.ToInt32(talantLvlTable.Rows[0]["total_weekly_boss"]);
                int total_mora = Convert.ToInt32(talantLvlTable.Rows[0]["total_mora"]);
                int total_crown = Convert.ToInt32(talantLvlTable.Rows[0]["total_crown"]);
                return new int[] { total_tal_book1, total_tal_book2, total_tal_book3, total_tal_res1, total_tal_res2, total_tal_res3, total_weekly_boss, total_mora, total_crown };
            }
            else
            {
                return new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            }
        }
        private int[] selectEvolution(int evol1, int evol2)
        {
            DataTable evolTable = characterRepository.GetEvolutionData(evol1, evol2);
            
            if (evol1 != evol2)
            {
                int total_material1 = Convert.ToInt32(evolTable.Rows[0]["total_material1"]);
                int total_material2 = Convert.ToInt32(evolTable.Rows[0]["total_material2"]);
                int total_material3 = Convert.ToInt32(evolTable.Rows[0]["total_material3"]);
                int total_material4 = Convert.ToInt32(evolTable.Rows[0]["total_material4"]);
                int total_boss_material = Convert.ToInt32(evolTable.Rows[0]["total_boss_material"]);
                int total_local_specialty = Convert.ToInt32(evolTable.Rows[0]["total_local_specialty"]);
                int total_mora = Convert.ToInt32(evolTable.Rows[0]["total_mora"]);
                return new int[] { total_material1, total_material2, total_material3, total_material4, total_boss_material, total_local_specialty, total_mora };
            }
            else
            {
                return new int[] { 0, 0, 0, 0, 0, 0, 0 };
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(char_name.Text))
            {
                MessageBox.Show("Вы не выбрали персонажа", "Выберите персонажа", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (lvl1.Value > lvl2.Value || v_1.Value > v_2.Value || tal1_1.Value > tal1_2.Value || tal2_1.Value > tal2_2.Value || tal3_1.Value > tal3_2.Value)
            {
                MessageBox.Show("Параметры выбраны неверно");
            }
            else if ((v_1.Value == 0 && lvl1.Value > 20) || 
                (v_1.Value == 1 && (lvl1.Value < 20 || lvl1.Value > 40)) || 
                (v_1.Value == 2 && (lvl1.Value < 40 || lvl1.Value > 50)) || 
                (v_1.Value == 3 && (lvl1.Value < 50 || lvl1.Value > 60)) ||
                (v_1.Value == 4 && (lvl1.Value < 60 || lvl1.Value > 70)) ||
                (v_1.Value == 5 && (lvl1.Value < 70 || lvl1.Value > 80)) ||
                (v_1.Value == 3 && lvl1.Value < 81)) 
            {
                MessageBox.Show("Параметры выбраны неверно");
            }
            else if ((v_2.Value == 0 && lvl2.Value > 20) ||
                (v_2.Value == 1 && (lvl2.Value < 20 || lvl2.Value > 40)) ||
                (v_2.Value == 2 && (lvl2.Value < 40 || lvl2.Value > 50)) ||
                (v_2.Value == 3 && (lvl2.Value < 50 || lvl2.Value > 60)) ||
                (v_2.Value == 4 && (lvl2.Value < 60 || lvl2.Value > 70)) ||
                (v_2.Value == 5 && (lvl2.Value < 70 || lvl2.Value > 80)) ||
                (v_2.Value == 3 && lvl2.Value < 81))
            {
                MessageBox.Show("Параметры выбраны неверно");
            }
            else
            {
                Расчёт result = new Расчёт();
                string[] charResult = setChar(char_name.Text);
                int[] lvlResult = selectLVL((int)lvl1.Value, (int)lvl2.Value);
                int[] talentResult1 = selectTalent_LVL((int)tal1_1.Value, (int)tal1_2.Value);
                int[] talentResult2 = selectTalent_LVL((int)tal2_1.Value, (int)tal2_2.Value);
                int[] talentResult3 = selectTalent_LVL((int)tal3_1.Value, (int)tal3_2.Value);
                int[] evolutionResult = selectEvolution((int)v_1.Value, (int)v_2.Value);
                result.SetCharacterData(charResult);
                result.SetEXP(lvlResult[0], lvlResult[1], lvlResult[2], lvlResult[3]);
                result.SetTalent(talentResult1[0] + talentResult2[0] + talentResult3[0],
                    talentResult1[1] + talentResult2[1] + talentResult3[1],
                    talentResult1[2] + talentResult2[2] + talentResult3[2],
                    talentResult1[3] + talentResult2[3] + talentResult3[3],
                    talentResult1[4] + talentResult2[4] + talentResult3[4],
                    talentResult1[5] + talentResult2[5] + talentResult3[5],
                    talentResult1[6] + talentResult2[6] + talentResult3[6],
                    talentResult1[7] + talentResult2[7] + talentResult3[7],
                    talentResult1[8] + talentResult2[8] + talentResult3[8]);
                result.SetEvolution(evolutionResult[0], evolutionResult[1], evolutionResult[2], evolutionResult[3], evolutionResult[4], evolutionResult[5], evolutionResult[6]);
                this.Hide();
                result.ShowDialog();
            }  
        }
        private void Меню(object sender, EventArgs e)
        {
            Меню oldForm = new Меню();
            this.Hide();
            oldForm.ShowDialog();
        }
        private void v_1_ValueChanged(object sender, EventArgs e)
        {
            if (v_1.Value > v_2.Value)
            {
                v_2.Value = v_1.Value;
            }
        }
        public void SetTal(decimal evol, NumericUpDown tal_lvl)
        {
            switch (evol)
            {
                case 1:
                    tal_lvl.Maximum = 1;
                    break;
                case 2:
                    tal_lvl.Maximum = 2;
                    break;
                case 3:
                    tal_lvl.Maximum = 4;
                    break;
                case 4:
                    tal_lvl.Maximum = 6;
                    break;
                case 5:
                    tal_lvl.Maximum = 8;
                    break;
                case 6:
                    tal_lvl.Maximum = 10;
                    break;
                default:
                    tal_lvl.Maximum = 10;
                    break;
            }
        }
        private void tal1_1_ValueChanged(object sender, EventArgs e)
        {
            SetTal(v_1.Value, tal1_1);
        }
        private void tal2_1_ValueChanged(object sender, EventArgs e)
        {
            SetTal(v_1.Value, tal2_1);
        }
        private void tal3_1_ValueChanged(object sender, EventArgs e)
        {
            SetTal(v_1.Value, tal3_1);
        }
        private void tal1_2_ValueChanged(object sender, EventArgs e)
        {
            SetTal(v_2.Value, tal1_2);
        }
        private void tal2_2_ValueChanged(object sender, EventArgs e)
        {
            SetTal(v_2.Value, tal2_2);
        }
        private void tal3_2_ValueChanged(object sender, EventArgs e)
        {
            SetTal(v_2.Value, tal3_2);
        }
        private void lvl1_ValueChanged(object sender, EventArgs e)
        {
            if (lvl2.Value < lvl1.Value)
            {
                lvl2.Value = lvl1.Value;
            }
        }
        private void Сяо_Click(object sender, EventArgs e)
        {
            char_name.Text = Сяо.Text;
        }
        private void Кадзуха_Click(object sender, EventArgs e)
        {
            char_name.Text = Кадзуха.Text;
        }
        private void Тома_Click(object sender, EventArgs e)
        {
            char_name.Text = Тома.Text;
        }
        private void Барбара_Click(object sender, EventArgs e)
        {
            char_name.Text = Барбара.Text;
        }
        private void ЧжунЛи_Click(object sender, EventArgs e)
        {
            char_name.Text = ЧжунЛи.Text;
        }
        private void ЯэМико_Click(object sender, EventArgs e)
        {
            char_name.Text = ЯэМико.Text;
        }
        private void Тигнари_Click(object sender, EventArgs e)
        {
            char_name.Text = Тигнари.Text;
        }
    }
}
