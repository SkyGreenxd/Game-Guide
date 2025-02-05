using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Руководство
{
    public partial class Персонажи : Form
    {
        Database database = new Database();
        characterFilter filter;
        private CharacterRepository characterRepository;
        public Персонажи()
        {
            InitializeComponent();
            characterRepository = new CharacterRepository(database);
            filter = new characterFilter(database, elements, charPanel);
            elements.SelectedIndexChanged += elements_SelectedIndexChanged;
        }
        private void elements_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedElement = elements.SelectedItem.ToString();
            filter.FilterCharacters(selectedElement);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Меню oldForm = new Меню();
            this.Hide();
            oldForm.ShowDialog();
        }
        protected void selectChar(string nameCharacter)
        {
            {
                DataTable characterInfoTable = characterRepository.GetCharacterInfo(nameCharacter);
                DataTable characterElementTable = characterRepository.GetCharacterElement(nameCharacter);
                DataTable characterAbilitiesTable = characterRepository.GetCharacterAbilities(nameCharacter);
                DataTable characterPassiveTable = characterRepository.GetCharacterPassiveAbilities(nameCharacter);
                DataTable characterConstTable = characterRepository.GetCharacterConstellations(nameCharacter);
                DataTable characterAbilityLevelUpTable = characterRepository.GetCharacterAbilityLevelUpResources(nameCharacter);
                DataTable characterLevelUpTable = characterRepository.GetCharacterLevelUpResources(nameCharacter);
                DataTable characterArtifactTable = characterRepository.GetCharacterArtifacts(nameCharacter);
                DataTable characterWeaponTable = characterRepository.GetCharacterWeapons(nameCharacter);
                // Extract element info
                List<string> element = new List<string>();
                foreach (DataRow row in characterElementTable.Rows)
                {
                    element.Add(row["name_element"].ToString());
                    element.Add(row["image"].ToString());
                }
                // Extract ability info
                List<string> abilityInfo = new List<string>();
                List<string> abilityImage = new List<string>();
                for (int i = 1; i <= 3; i++)
                {
                    abilityInfo.Add(characterAbilitiesTable.Rows[0][$"ability{i}_info"].ToString());
                    abilityImage.Add(characterAbilitiesTable.Rows[0][$"ability{i}_image"].ToString());
                }
                // Extract passive ability info
                List<string> pasInfo = new List<string>();
                List<string> pasImage = new List<string>();
                for (int i = 1; i <= 3; i++)
                {
                    pasInfo.Add(characterPassiveTable.Rows[0][$"pas{i}_info"].ToString());
                    pasImage.Add(characterPassiveTable.Rows[0][$"pas{i}_image"].ToString());
                }
                // Extract constellation info
                List<string> cInfo = new List<string>();
                List<string> cImage = new List<string>();
                for (int i = 1; i <= 6; i++)
                {
                    cInfo.Add(characterConstTable.Rows[0][$"const{i}_info"].ToString());
                    cImage.Add(characterConstTable.Rows[0][$"const{i}_image"].ToString());
                }
                // Extract ability level-up resources info
                List<string> imagePathsAbilLvlup = new List<string>();
                foreach (DataRow row in characterAbilityLevelUpTable.Rows)
                {
                    imagePathsAbilLvlup.Add(row["name_resource"].ToString());
                }
                string[] abillvlup = characterRepository.InitializeArrayFromList(imagePathsAbilLvlup);
                // Extract character level-up resources info
                List<string> imagePathsCharLvlup = new List<string>();
                foreach (DataRow row in characterLevelUpTable.Rows)
                {
                    imagePathsCharLvlup.Add(row["name_resource"].ToString());
                }
                string[] charlvlup = characterRepository.InitializeArrayFromList(imagePathsCharLvlup);
                // Extract artifact info
                List<string> artInfo = new List<string>();
                List<string> artImage = new List<string>();
                artInfo.Add(characterArtifactTable.Rows[0]["artifact_name"].ToString());
                artImage.Add(characterArtifactTable.Rows[0]["image"].ToString());
                for (int i = 1; i <= 3; i++)
                {
                    artInfo.Add(characterArtifactTable.Rows[0][$"art_{i}_info"].ToString());
                }
                // Extract weapon info
                List<string> weaponInfo = new List<string>();
                List<string> weaponImage = new List<string>();
                for (int i = 1; i <= 4; i++)
                {
                    weaponInfo.Add(characterWeaponTable.Rows[0][$"weapon{i}_name"].ToString());
                    weaponImage.Add(characterWeaponTable.Rows[0][$"weapon{i}_image"].ToString());
                }
                // Pass data to character details form
                Информация_о_персонажах characterDetailsForm = new Информация_о_персонажах();
                this.Hide();
                characterDetailsForm.SetCharacterData(characterInfoTable.Rows[0]["name"].ToString(), characterInfoTable.Rows[0]["info"].ToString(), characterInfoTable.Rows[0]["image"].ToString());
                characterDetailsForm.SetElement(element[0], element[1]);
                characterDetailsForm.SetAbility(abilityInfo, abilityImage);
                characterDetailsForm.SetPassive(pasInfo, pasImage);
                characterDetailsForm.SetConst(cInfo, cImage);
                characterDetailsForm.SetAbilitylvlup(abillvlup);
                characterDetailsForm.SetCharlvlup(charlvlup);
                characterDetailsForm.SetArtifact(artInfo, artImage);
                characterDetailsForm.SetWeapon(weaponInfo, weaponImage);
                characterDetailsForm.ShowDialog();
            }
        }
        protected void Казуха_Click(object sender, EventArgs e)
        {
            selectChar(Кадзуха.Text);
        }
        private void Сяо_Click(object sender, EventArgs e)
        {
            selectChar(Сяо.Text);
        }
        private void Тома_Click(object sender, EventArgs e)
        {
            selectChar(Тома.Text);
        }
        private void Барбара_Click(object sender, EventArgs e)
        {
            selectChar(Барбара.Text);
        }
        private void ЧжунЛи_Click(object sender, EventArgs e)
        {
            selectChar(ЧжунЛи.Text);
        }
        private void ЯэМико_Click(object sender, EventArgs e)
        {
            selectChar(ЯэМико.Text);
        }
        private void Тигнари_Click(object sender, EventArgs e)
        {
            selectChar(Тигнари.Text);
        }
    }
}
