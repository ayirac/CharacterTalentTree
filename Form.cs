using BegottenCharacterBuildsBelief.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BegottenCharacterBuildsBelief
{
    public partial class Form1 : Form
    {
        int beliefsLeft = 40;
        System.Timers.Timer timer;
        Boolean hover = false;

        String fighterToolTipInfo = "You gain 10 poise and unlock the poise tree.";
        String wrestleToolTipInfo = "You are able to pick up subdued people on the floor.";

        public Form1()
        {
            InitializeComponent();

            //Prowess
            BeliefOverlay(pictureBoxFighter, pictureBoxFighterUnder);
            BeliefOverlay(pictureBoxWrestle, pictureBoxWrestleUnder);
            BeliefOverlay(pictureBoxWarrior, pictureBoxWarriorUnder);
            BeliefOverlay(pictureBoxMasterAtArms, pictureBoxMasterAtArmsUnder);
            BeliefOverlay(pictureBoxHalfSwordSway, pictureBoxHalfswordSwayUnder);
            BeliefOverlay(pictureBoxBladeMaster, pictureBoxBlademasterUnder);
            BeliefOverlay(pictureBoxBillman, pictureBoxBillmanUnder);
            BeliefOverlay(pictureBoxParrying, pictureBoxParryingUnder);
            BeliefOverlay(pictureBoxRepulsive, pictureBoxRepulsiveUnder);
            BeliefOverlay(pictureBoxDeflection, pictureBoxDeflectionUnder);
            BeliefOverlay(pictureBoxSidestep, pictureBoxSidestepUnder);
            BeliefOverlay(pictureBoxStrength, pictureBoxStrengthUnder);
            BeliefOverlay(pictureBoxMight, pictureBoxMightUnder);
            BeliefOverlay(pictureBoxUnrelenting, pictureBoxUnrelentingUnder);

            //Brutality
            BeliefOverlay(pictureBoxSavage, pictureBoxSavageUnder);
            BeliefOverlay(pictureBoxPrimeval, pictureBoxPrimevalUnder);
            BeliefOverlay(pictureBoxHeadTaker, pictureBoxHeadTakerUnder);
            BeliefOverlay(pictureBoxHeartEater, pictureBoxHeartEaterUnder);
            BeliefOverlay(pictureBoxBestial, pictureBoxBestialUnder);
            BeliefOverlay(pictureBoxSavageAnimal, pictureBoxSavageAnimalUnder);

            //Fortune
            BeliefOverlay(pictureBoxFortunate, pictureBoxFortunateUnder);
            BeliefOverlay(pictureBoxLucky, pictureBoxLuckyUnder);
            BeliefOverlay(pictureBoxFavored, pictureBoxFavoredUnder);
            BeliefOverlay(pictureBoxTalented, pictureBoxTalentedUnder);
            BeliefOverlay(pictureBoxGifted, pictureBoxGiftedUnder);
            BeliefOverlay(pictureBoxJOAT, pictureBoxJOATUnder);

            //Litheness
            BeliefOverlay(pictureBoxNimble, pictureBoxNimbleUnder);
            BeliefOverlay(pictureBoxSkyFidget, pictureBoxSkyFidgetUnder);
            BeliefOverlay(pictureBoxSafecracker, pictureBoxSafecrackerUnder);
            BeliefOverlay(pictureBoxThief, pictureBoxThiefUnder);
            BeliefOverlay(pictureBoxDexterity, pictureBoxDexterityUnder);
            BeliefOverlay(pictureBoxSwift, pictureBoxSwiftUnder);
            BeliefOverlay(pictureBoxEvasion, pictureBoxEvasionUnder);

            //Ingenuity
            BeliefOverlay(pictureBoxIngenious, pictureBoxIngeniousUnder);
            BeliefOverlay(pictureBoxCraftsman, pictureBoxCraftsmanUnder);
            BeliefOverlay(pictureBoxMechanic, pictureBoxMechanicUnder);
            BeliefOverlay(pictureBoxArtisan, pictureBoxArtisanUnder);
            BeliefOverlay(pictureBoxSmith, pictureBoxSmithUnder);
            BeliefOverlay(pictureBoxBlacksmith, pictureBoxBlacksmithUnder);
            BeliefOverlay(pictureBoxMasterBlacksmith, pictureBoxMasterBlacksmithUnder);
            BeliefOverlay(pictureBoxScourRust, pictureBoxScourRustUnder);
            BeliefOverlay(pictureBoxFortifiedPlate, pictureBoxFortifiedPlateUnder);
            BeliefOverlay(pictureBoxPowderSteel, pictureBoxPowderSteelUnder);
            BeliefOverlay(pictureBoxPistolier, pictureBoxPistolierUnder);
            BeliefOverlay(pictureBoxMarksman, pictureBoxMarksmanUnder);
            BeliefOverlay(pictureBoxCookist, pictureBoxCookistUnder);
            BeliefOverlay(pictureBoxCulinarian, pictureBoxCullinarianUnder);

            //Aptiptude
            BeliefOverlay(pictureBoxLiteracy, pictureBoxLiteracyUnder);
            BeliefOverlay(pictureBoxScribe, pictureBoxScribeUnder);
            BeliefOverlay(pictureBoxAnthropology, pictureBoxAnthropologyUnder);
            BeliefOverlay(pictureBoxLoremaster, pictureBoxLoremasterUnder);
            BeliefOverlay(pictureBoxSanitary, pictureBoxSanitaryUnder);
            BeliefOverlay(pictureBoxDoctor, pictureBoxDoctorUnder);
            BeliefOverlay(pictureBoxSurgeon, pictureBoxSurgeonUnder);
            BeliefOverlay(pictureBoxMedicineMan, pictureBoxMedicineManUnder);
            BeliefOverlay(pictureBoxPlagueDoctor, pictureBoxPlagueDoctorUnder);
            BeliefOverlay(pictureBoxAlchemist, pictureBoxAlchemistUnder);
            BeliefOverlay(pictureBoxChemist, pictureBoxChemistUnder);
            BeliefOverlay(pictureBoxScientist, pictureBoxScientistUnder);
            BeliefOverlay(pictureBoxMeasurement, pictureBoxMeasurementUnder);
            BeliefOverlay(pictureBoxBloodNectar, pictureBoxBloodNectarUnder);

            //Fortitude
            BeliefOverlay(pictureBoxAsceticism, pictureBoxAsceticismUnder);
            BeliefOverlay(pictureBoxOutlasting, pictureBoxOutlastingUnder);
            BeliefOverlay(pictureBoxPrudence, pictureBoxPrudenceUnder);
            BeliefOverlay(pictureBoxComposure, pictureBoxComposureUnder);
            BeliefOverlay(pictureBoxRepudation, pictureBoxRepudationUnder);
            BeliefOverlay(pictureBoxDefender, pictureBoxDefenderUnder);
            BeliefOverlay(pictureBoxWarden, pictureBoxWardenUnder);
            BeliefOverlay(pictureBoxHauberk, pictureBoxHauberkUnder);
            BeliefOverlay(pictureBoxUnburdened, pictureBoxUnburdenedUnder);
            BeliefOverlay(pictureBoxPerserverance, pictureBoxPerserveranceUnder);
            BeliefOverlay(pictureBoxPlentyToSpill, pictureBoxPlentyToSpillUnder);
            BeliefOverlay(pictureBoxUnyielding, pictureBoxUnyieldingUnder);
            BeliefOverlay(pictureBoxHideOfSteel, pictureBoxHideOfSteelUnder);
            BeliefOverlay(pictureBoxIronBones, pictureBoxIronBonesUnder);


            //FOTF
            BeliefOverlay(pictureBoxFather, pictureBoxFatherUnder);
            BeliefOverlay(pictureBoxHonorTheGods, pictureBoxHonorTheGodsUnder);
            BeliefOverlay(pictureBoxManBeast, pictureBoxManBeastUnder);
            BeliefOverlay(pictureBoxFearsomeWolf, pictureBoxFearsomeWolfUnder);

            BeliefOverlay(pictureBoxMother, pictureBoxMotherUnder);
            BeliefOverlay(pictureBoxDruid, pictureBoxDruidUnder);
            BeliefOverlay(pictureBoxGreatTree, pictureBoxGreatTreeUnder);
            BeliefOverlay(pictureBoxWatchfulRaven, pictureBoxWatchfulRavenUnder);

            BeliefOverlay(pictureBoxOldSon, pictureBoxOldSonUnder);
            BeliefOverlay(pictureBoxBlackSea, pictureBoxBlackSeaUnder);
            BeliefOverlay(pictureBoxTasteOfBlood, pictureBoxTasteOfBloodUnder);
            BeliefOverlay(pictureBoxDaringTrout, pictureBoxDaringTroutUnder);

            BeliefOverlay(pictureBoxYoungSon, pictureBoxYoungSonUnder);
            BeliefOverlay(pictureBoxTasteOfIron, pictureBoxTasteOfIronUnder);
            BeliefOverlay(pictureBoxShieldwall, pictureBoxShieldwallUnder);
            BeliefOverlay(pictureBoxEnduringBear, pictureBoxEnduringBearUnder);

            BeliefOverlay(pictureBoxSister, pictureBoxSisterUnder);
            BeliefOverlay(pictureBoxWitchDruid, pictureBoxWitchDruidUnder);
            BeliefOverlay(pictureBoxShedskin, pictureBoxShedskinUnder);
            BeliefOverlay(pictureBoxDecietfulSnake, pictureBoxDecietfulSnakeUnder);


            //FOTD
            BeliefOverlay(pictureBoxPrimevalism, pictureBoxPrimevalismUnder);
            BeliefOverlay(pictureBoxDarkCreature, pictureBoxDarkCreatureUnder);
            BeliefOverlay(pictureBoxSoothsayer, pictureBoxSoothsayerUnder);
            BeliefOverlay(pictureBoxSurvivalist, pictureBoxSurvivalistUnder);
            BeliefOverlay(pictureBoxDarkEmbrace, pictureBoxDarkEmbraceUnder);
            BeliefOverlay(pictureBoxBloodMoon, pictureBoxBloodMoonUnder);

            BeliefOverlay(pictureBoxSatanism, pictureBoxSatanismUnder);
            BeliefOverlay(pictureBoxWitch, pictureBoxWitchUnder);
            BeliefOverlay(pictureBoxHeretic, pictureBoxHereticUnder);
            BeliefOverlay(pictureBoxSorcerer, pictureBoxSorcererUnder);
            BeliefOverlay(pictureBoxMurderRepetance, pictureBoxMurderArtformUnder);
            BeliefOverlay(pictureBoxFlamboyance, pictureBoxFlamboyanceUnder);
            BeliefOverlay(pictureBoxUnendingDance, pictureBoxUnendingDanceUnder);
            BeliefOverlay(pictureBoxImpossibilySkilled, pictureBoxImpossibilySkilledUnder);
            BeliefOverlay(pictureBoxBlankStare, pictureBoxBlankStareUnder);
            BeliefOverlay(pictureBoxEncore, pictureBoxEncoreUnder);
            BeliefOverlay(pictureBoxAssassin, pictureBoxAssassinUnder);
            BeliefOverlay(pictureBoxSadism, pictureBoxSadismUnder);

            //FOTL
            BeliefOverlay(pictureBoxSolOrth, pictureBoxSolOrthUnder);
            BeliefOverlay(pictureBoxRepentant, pictureBoxRepentantUnder);
            BeliefOverlay(pictureBoxFlagellant, pictureBoxFlagellantUnder);
            BeliefOverlay(pictureBoxExtinctionist, pictureBoxExtinctionistUnder);
            BeliefOverlay(pictureBoxFleshPrison, pictureBoxFleshPrisonUnder);
            BeliefOverlay(pictureBoxPurityAfloat, pictureBoxPurityAfloatUnder);
            BeliefOverlay(pictureBoxFanatic, pictureBoxFanaticUnder);

            BeliefOverlay(pictureBoxHardGlazed, pictureBoxHardGlazedUnder);
            BeliefOverlay(pictureBoxDisciple, pictureBoxDiscipleUnder);
            BeliefOverlay(pictureBoxAcolyte, pictureBoxAcolyteUnder);
            BeliefOverlay(pictureBoxEmissary, pictureBoxEmissaryUnder);
            BeliefOverlay(pictureBoxTheLight, pictureBoxTheLightUnder);
            BeliefOverlay(pictureBoxBlessedPowder, pictureBoxBlessedPowderUnder);
            BeliefOverlay(pictureBoxTheManifesto, pictureBoxTheManifestoUnder);

            BeliefOverlay(pictureBoxVoltism, pictureBoxVoltismUnder);
            BeliefOverlay(pictureBoxWireTherapy, pictureBoxWireTherapyUnder);
            BeliefOverlay(pictureBoxJacobsLadder, pictureBoxJacobsLadderUnder);
            BeliefOverlay(pictureBoxParadoxRiddle, pictureBoxParadoxRiddleUnder);
            BeliefOverlay(pictureBoxWriggleEel, pictureBoxWriggleEelUnder);
            BeliefOverlay(pictureBoxYellowBlack, pictureBoxYellowBlackUnder);
            BeliefOverlay(pictureBoxTheStorm, pictureBoxTheStormUnder);

            customRichTextBoxInit();
            customFontInit();
        }

        public static void BeliefOverlay(PictureBox overlay, PictureBox underlay)
        {
            overlay.Parent = underlay;
            overlay.Location = Point.Empty;
            overlay.Visible = false;
        }

        // - Prowess - 
        // Fighter
        private void pictureBoxFighterUnder_Click(object sender, EventArgs e)
        {
            if (beliefsLeft > 0)
            {
                pictureBoxFighter.Visible = true;
                beliefsLeft -= 1;
                labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
            }
            
        }

        private void pictureBoxFighter_Click(object sender, EventArgs e)
        {
            if (pictureBoxWrestle.Visible == false && pictureBoxDeflection.Visible == false && pictureBoxHalfSwordSway.Visible == false && pictureBoxParrying.Visible == false && pictureBoxStrength.Visible == false)
            {
                pictureBoxFighter.Visible = false;
                beliefsLeft += 1;
                labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
            }

        }

        // Wrestle 
        private void pictureBoxWrestleUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxFighter, pictureBoxWrestle);
        }

        private void pictureBoxWrestle_Click(object sender, EventArgs e)
        {
            if (pictureBoxWarrior.Visible == false)
            {
                pictureBoxWrestle.Visible = false;
                beliefsLeft += 1;
                labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
            }
        }

        // Warrior
        private void pictureBoxWarriorUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxWrestle, pictureBoxWarrior);

        }

        private void pictureBoxWarrior_Click(object sender, EventArgs e)
        {
            if (pictureBoxMasterAtArms.Visible == false)
            {
                pictureBoxWarrior.Visible = false;
                beliefsLeft += 1;
                labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
            }

        }

        // Master At Arms
        private void pictureBoxMasterAtArmsUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxWarrior, pictureBoxMasterAtArms);

        }

        private void pictureBoxMasterAtArms_Click(object sender, EventArgs e)
        {
            pictureBoxMasterAtArms.Visible = false;
            beliefsLeft += 1;
            labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
        }

        // Deflection
        private void pictureBoxDeflectionUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxFighter, pictureBoxDeflection);
        }
        private void pictureBoxDeflection_Click(object sender, EventArgs e)
        {
            if (pictureBoxSidestep.Visible == false)
            {
                pictureBoxDeflection.Visible = false;
                beliefsLeft += 1;
                labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
            }

        }

        // Sidestep
        private void pictureBoxSidestepUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxDeflection, pictureBoxSidestep);
        }

        private void pictureBoxSidestep_Click(object sender, EventArgs e)
        {
            pictureBoxSidestep.Visible = false;
            beliefsLeft += 1;
            labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
        }

        // Strength
        private void pictureBoxStrengthUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxFighter, pictureBoxStrength);
        }
        private void pictureBoxStrength_Click(object sender, EventArgs e)
        {
            if (pictureBoxMight.Visible == false)
            {
                pictureBoxStrength.Visible = false;
                beliefsLeft += 1;
                labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
            }
        }               

    // Might
    private void pictureBoxMightUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxStrength, pictureBoxMight);
        }

        private void pictureBoxMight_Click(object sender, EventArgs e)
        {
            if (pictureBoxUnrelenting.Visible == false)
            {
                pictureBoxMight.Visible = false;
                beliefsLeft += 1;
                labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
            }
        }

        // Unrelenting
        private void pictureBoxUnrelentingUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxMight, pictureBoxUnrelenting);
        }

        private void pictureBoxUnrelenting_Click(object sender, EventArgs e)
        {
            pictureBoxUnrelenting.Visible = false;
            beliefsLeft += 1;
            labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
        }

        // Halfsword Sway
        private void pictureBoxHalfswordSwayUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxFighter, pictureBoxHalfSwordSway);
        }

        private void pictureBoxHalfSwordSway_Click(object sender, EventArgs e)
        {
            if (pictureBoxBladeMaster.Visible == false)
            {
                pictureBoxHalfSwordSway.Visible = false;
                beliefsLeft += 1;
                labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
            }

        }

        // Blademaster
        private void pictureBoxBlademasterUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxHalfSwordSway, pictureBoxBladeMaster);
        }
        private void pictureBoxBladeMaster_Click(object sender, EventArgs e)
        {
            if (pictureBoxBillman.Visible == false)
            {
                pictureBoxBladeMaster.Visible = false;
                beliefsLeft += 1;
                labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
            }
        }

        // Billman
        private void pictureBoxBillmanUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxBladeMaster, pictureBoxBillman);
        }

        private void pictureBoxBillman_Click(object sender, EventArgs e)
        {
            pictureBoxBillman.Visible = false;
            beliefsLeft += 1;
            labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
        }

        // Parrying
        private void pictureBoxParryingUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxFighter, pictureBoxParrying);
        }

        private void pictureBoxParrying_Click(object sender, EventArgs e)
        {
            if (pictureBoxRepulsive.Visible == false)
            {
                pictureBoxParrying.Visible = false;
                beliefsLeft += 1;
                labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
            }
        }

        // Repulsive Riposte
        private void pictureBoxRepulsiveUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxParrying, pictureBoxRepulsive);
        }

        private void pictureBoxRepulsive_Click(object sender, EventArgs e)
        {
            pictureBoxRepulsive.Visible = false;
            beliefsLeft += 1;
            labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
        }

        // - Brutality - 
        // Savage
        private void pictureBoxSavageUnder_Click(object sender, EventArgs e)
        {
            
            if (beliefsLeft > 0)
            {
                pictureBoxSavage.Visible = true;
                beliefsLeft -= 1;
                labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
            }
        }

        private void pictureBoxSavage_Click(object sender, EventArgs e)
        {
            if (pictureBoxPrimeval.Visible == false && pictureBoxHeartEater.Visible == false)
            {
                pictureBoxSavage.Visible = false;
                beliefsLeft += 1;
                labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
            }

        }

        // Primeval 
        private void pictureBoxPrimevalUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxSavage, pictureBoxPrimeval);
        }

        private void pictureBoxPrimeval_Click(object sender, EventArgs e)
        {
            pictureBoxClick(pictureBoxHeadTaker, pictureBoxPrimeval);
        }

        // Heart Eater
        private void pictureBoxHeartEaterUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxSavage, pictureBoxHeartEater);
        }

        private void pictureBoxHeartEater_Click(object sender, EventArgs e)
        {
            pictureBoxClick(pictureBoxBestial, pictureBoxHeartEater);
        }

        // Bestial
        private void pictureBoxBestialUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxHeartEater, pictureBoxBestial);
        }

        private void pictureBoxBestial_Click(object sender, EventArgs e)
        {
            pictureBoxClick(pictureBoxSavageAnimal, pictureBoxBestial);
        }

        // Head Taker
        private void pictureBoxHeadTakerUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxPrimeval, pictureBoxHeadTaker);
        }

        private void pictureBoxHeadTaker_Click(object sender, EventArgs e)
        {
            pictureBoxClick(pictureBoxSavageAnimal, pictureBoxHeadTaker);
        }

        // Savage Animal
        private void pictureBoxSavageAnimalUnder_Click(object sender, EventArgs e)
        {
            if (pictureBoxHeadTaker.Visible == true && pictureBoxBestial.Visible == true && beliefsLeft > 0)
            {
                pictureBoxSavageAnimal.Visible = true;
                beliefsLeft -= 1;
                labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
            }
            else
            {
                MessageBox.Show("Please take the prerequisite");
            }
        }

        private void pictureBoxSavageAnimal_Click(object sender, EventArgs e)
        {
            pictureBoxSavageAnimal.Visible = false;
            beliefsLeft += 1;
            labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
        }

        // Fortunate
        private void pictureBoxFortunateUnder_Click(object sender, EventArgs e)
        {
            
            if (beliefsLeft > 0)
            {
                pictureBoxFortunate.Visible = true;
                beliefsLeft -= 1;
                labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
            }
        }

        private void pictureBoxFortunate_Click(object sender, EventArgs e)
        {
            pictureBoxClick(pictureBoxLucky, pictureBoxFortunate);
        }

        // Talented
        private void pictureBoxTalentedUnder_Click(object sender, EventArgs e)
        {
            
            if (beliefsLeft > 0)
            {
                pictureBoxTalented.Visible = true;
                beliefsLeft -= 1;
                labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
            }
        }

        private void pictureBoxTalented_Click(object sender, EventArgs e)
        {
            pictureBoxClick(pictureBoxGifted, pictureBoxTalented);
        }

        //Lucky
        private void pictureBoxLuckyUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxFortunate, pictureBoxLucky);
        }

        private void pictureBoxLucky_Click(object sender, EventArgs e)
        {
            pictureBoxClick(pictureBoxFavored, pictureBoxLucky);
        }

        // Gifted
        private void pictureBoxGiftedUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxTalented, pictureBoxGifted);
        }

        private void pictureBoxGifted_Click(object sender, EventArgs e)
        {
            pictureBoxClick(pictureBoxJOAT, pictureBoxGifted);
        }

        // Favored
        private void pictureBoxFavoredUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxLucky, pictureBoxFavored);
        }

        private void pictureBoxFavored_Click(object sender, EventArgs e)
        {
            pictureBoxFavored.Visible = false;
            beliefsLeft += 1;
            labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
        }

        // JOAT
        private void pictureBoxJOATUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxGifted, pictureBoxJOAT);
        }

        private void pictureBoxJOAT_Click(object sender, EventArgs e)
        {
            pictureBoxJOAT.Visible = false;
            beliefsLeft += 1;
            labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
        }

        // Nimble

        private void pictureBoxNimbleUnder_Click(object sender, EventArgs e)
        {
            
            if (beliefsLeft > 0)
            {
                pictureBoxNimble.Visible = true;
                beliefsLeft -= 1;
                labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
            }
        }

        private void pictureBoxNimble_Click(object sender, EventArgs e)
        {
            if (pictureBoxSkyFidget.Visible == false && pictureBoxDexterity.Visible == false)
            {
                pictureBoxNimble.Visible = false;
                beliefsLeft += 1;
                labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
            }
        }

        // Skyfidget
        private void pictureBoxSkyFidgetUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxNimble, pictureBoxSkyFidget);
        }
        private void pictureBoxSkyFidget_Click(object sender, EventArgs e)
        {
            pictureBoxClick(pictureBoxSafecracker, pictureBoxSkyFidget);
        }

        // Safecracker
        private void pictureBoxSafecrackerUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxSkyFidget, pictureBoxSafecracker);
        }

        private void pictureBoxSafecracker_Click(object sender, EventArgs e)
        {
            pictureBoxClick(pictureBoxThief, pictureBoxSafecracker);
        }


        // Thief
        private void pictureBoxThiefUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxSafecracker, pictureBoxThief);
        }

        private void pictureBoxThief_Click(object sender, EventArgs e)
        {
            pictureBoxThief.Visible = false;
            beliefsLeft += 1;
            labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
        }

        // Dexterity
        private void pictureBoxDexterityUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxNimble, pictureBoxDexterity);
        }

        private void pictureBoxDexterity_Click(object sender, EventArgs e)
        {
            pictureBoxClick(pictureBoxSwift, pictureBoxDexterity);
        }

        // Swift
        private void pictureBoxSwiftUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxDexterity, pictureBoxSwift);
        }

        private void pictureBoxSwift_Click(object sender, EventArgs e)
        {
            pictureBoxClick(pictureBoxEvasion, pictureBoxSwift);
        }

        // Evasion
        private void pictureBoxEvasionUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxSwift, pictureBoxEvasion);

        }

        private void pictureBoxEvasion_Click(object sender, EventArgs e)
        {
            pictureBoxEvasion.Visible = false;
            beliefsLeft += 1;
            labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
        }


        // Ingenious
        private void pictureBoxIngeniousUnder_Click(object sender, EventArgs e)
        {
            
            if (beliefsLeft > 0)
            {
                pictureBoxIngenious.Visible = true;
                beliefsLeft -= 1;
                labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
            }
        }

        private void pictureBoxIngenious_Click(object sender, EventArgs e)
        {
            if (pictureBoxCookist.Visible == false && pictureBoxPowderSteel.Visible == false && pictureBoxCraftsman.Visible == false && pictureBoxSmith.Visible == false && pictureBoxScourRust.Visible == false)
            {
                pictureBoxIngenious.Visible = false;
                beliefsLeft += 1;
                labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
            }
        }


        // Craftsman
        private void pictureBoxCraftsmanUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxIngenious, pictureBoxCraftsman);
        }

        private void pictureBoxCraftsman_Click(object sender, EventArgs e)
        {
            pictureBoxClick(pictureBoxMechanic, pictureBoxCraftsman);
        }


        // Mechanic
        private void pictureBoxMechanicUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxCraftsman, pictureBoxMechanic);
        }

        private void pictureBoxMechanic_Click(object sender, EventArgs e)
        {
            pictureBoxClick(pictureBoxArtisan, pictureBoxMechanic);
        }

        // Artisan
        private void pictureBoxArtisanUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxMechanic, pictureBoxArtisan);
        }
        private void pictureBoxArtisan_Click(object sender, EventArgs e)
        {
            pictureBoxArtisan.Visible = false;
            beliefsLeft += 1;
            labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
        }


        // Power Steel
        private void pictureBoxPowderSteelUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxIngenious, pictureBoxPowderSteel);
        }

        private void pictureBoxPowderSteel_Click(object sender, EventArgs e)
        {
            pictureBoxClick(pictureBoxPistolier, pictureBoxPowderSteel);
        }


        // Pistolier
        private void pictureBoxPistolierUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxPowderSteel, pictureBoxPistolier);
        }

        private void pictureBoxPistolier_Click(object sender, EventArgs e)
        {
            pictureBoxClick(pictureBoxMarksman, pictureBoxPistolier);
        }

        // marksman
        private void pictureBoxMarksmanUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxPistolier, pictureBoxMarksman);
        }

        private void pictureBoxMarksman_Click(object sender, EventArgs e)
        {
            pictureBoxMarksman.Visible = false;
            beliefsLeft += 1;
            labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
        }

        // cookist
        private void pictureBoxCookistUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxIngenious, pictureBoxCookist);
        }

        private void pictureBoxCookist_Click(object sender, EventArgs e)
        {
            pictureBoxClick(pictureBoxCulinarian, pictureBoxCookist);
        }

        //cullinarian
        private void pictureBoxCullinarianUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxCookist, pictureBoxCulinarian);
        }

        private void pictureBoxCullinarian_Click(object sender, EventArgs e)
        {
            pictureBoxCulinarian.Visible = false;
            beliefsLeft += 1;
            labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
        }

        //smith
        private void pictureBoxSmithUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxIngenious, pictureBoxSmith);
        }

        private void pictureBoxSmith_Click(object sender, EventArgs e)
        {
            pictureBoxClick(pictureBoxBlacksmith, pictureBoxSmith);
        }

        //blacksmith
        private void pictureBoxBlacksmithUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxSmith, pictureBoxBlacksmith);
        }
        private void pictureBoxBlacksmith_Click(object sender, EventArgs e)
        {
            pictureBoxClick(pictureBoxMasterBlacksmith, pictureBoxBlacksmith);
        }

        // master blacksmith
        private void pictureBoxMasterBlacksmithUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxBlacksmith, pictureBoxMasterBlacksmith);
        }

        private void pictureBoxMasterBlacksmith_Click(object sender, EventArgs e)
        {
            pictureBoxMasterBlacksmith.Visible = false;
            beliefsLeft += 1;
            labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
        }

        //scour
        private void pictureBoxScourRustUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxIngenious, pictureBoxScourRust);
        }
        private void pictureBoxScourRust_Click(object sender, EventArgs e)
        {
            pictureBoxClick(pictureBoxFortifiedPlate, pictureBoxScourRust);
        }

        //fortified
        private void pictureBoxFortifiedPlateUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxScourRust, pictureBoxFortifiedPlate);
        }

        private void pictureBoxFortifiedPlate_Click(object sender, EventArgs e)
        {
            pictureBoxFortifiedPlate.Visible = false;
            beliefsLeft += 1;
            labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
        }

        //Fortitude
        //asceticism
        private void pictureBoxAsceticismUnder_Click(object sender, EventArgs e)
        {
            
            if (beliefsLeft > 0)
            {
                pictureBoxAsceticism.Visible = true;
                beliefsLeft -= 1;
                labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
            }
        }

        private void pictureBoxAsceticism_Click(object sender, EventArgs e)
        {
            pictureBoxClick(pictureBoxOutlasting, pictureBoxAsceticism);
        }

        //outlasting
        private void pictureBoxOutlastingUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxAsceticism, pictureBoxOutlasting);
        }

        private void pictureBoxOutlasting_Click(object sender, EventArgs e)
        {
            pictureBoxOutlasting.Visible = false;
            beliefsLeft += 1;
            labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
        }

        //prudence
        private void pictureBoxPrudenceUnder_Click(object sender, EventArgs e)
        {
            
            if (beliefsLeft > 0)
            {
                pictureBoxPrudence.Visible = true;
                beliefsLeft -= 1;
                labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
            }
        }
        private void pictureBoxPrudence_Click(object sender, EventArgs e)
        {
            pictureBoxClick(pictureBoxComposure, pictureBoxPrudence);
        }

        //composure
        private void pictureBoxComposureUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxPrudence, pictureBoxComposure);
        }

        private void pictureBoxComposure_Click(object sender, EventArgs e)
        {
            pictureBoxClick(pictureBoxRepudation, pictureBoxComposure);
        }

        //repduation
        private void pictureBoxRepudationUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxComposure, pictureBoxRepudation);
        }
        private void pictureBoxRepudation_Click(object sender, EventArgs e)
        {
            pictureBoxRepudation.Visible = false;
            beliefsLeft += 1;
            labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
        }

        //defender
        private void pictureBoxDefenderUnder_Click(object sender, EventArgs e)
        {
            
            if (beliefsLeft > 0)
            {
                pictureBoxDefender.Visible = true;
                beliefsLeft -= 1;
                labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
            }
        }

        private void pictureBoxDefender_Click(object sender, EventArgs e)
        {
            pictureBoxClick(pictureBoxWarden, pictureBoxDefender);
        }

        //warden
        private void pictureBoxWardenUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxDefender, pictureBoxWarden);
        }

        private void pictureBoxWarden_Click(object sender, EventArgs e)
        {
            pictureBoxClick(pictureBoxHauberk, pictureBoxWarden);
        }

        //hauberk
        private void pictureBoxHauberkUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxWarden, pictureBoxHauberk);
        }

        private void pictureBoxHauberk_Click(object sender, EventArgs e)
        {
            pictureBoxClick(pictureBoxUnburdened, pictureBoxHauberk);
        }

        //unburdened
        private void pictureBoxUnburdenedUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxHauberk, pictureBoxUnburdened);
        }

        private void pictureBoxUnburdened_Click(object sender, EventArgs e)
        {
            pictureBoxUnburdened.Visible = false;
            beliefsLeft += 1;
            labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
        }

        //perservance
        private void pictureBoxPerserveranceUnder_Click(object sender, EventArgs e)
        {
            
            if (beliefsLeft > 0)
            {
                pictureBoxPerserverance.Visible = true;
                beliefsLeft -= 1;
                labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
            }
        }

        private void pictureBoxPerserverance_Click(object sender, EventArgs e)
        {
            pictureBoxClick(pictureBoxPlentyToSpill, pictureBoxPerserverance);
        }

        //plenty to spill
        private void pictureBoxPlentyToSpillUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxPerserverance, pictureBoxPlentyToSpill);
        }
        private void pictureBoxPlentyToSpill_Click(object sender, EventArgs e)
        {
            pictureBoxClick(pictureBoxUnyielding, pictureBoxPlentyToSpill);
        }

        //unyielding
        private void pictureBoxUnyieldingUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxPlentyToSpill, pictureBoxUnyielding);
        }
        private void pictureBoxUnyielding_Click(object sender, EventArgs e)
        {
            pictureBoxUnyielding.Visible = false;
            beliefsLeft += 1;
            labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
        }

        //hide of steel
        private void pictureBoxHideOfSteelUnder_Click(object sender, EventArgs e)
        {
            
            if (beliefsLeft > 0)
            {
                pictureBoxHideOfSteel.Visible = true;
                beliefsLeft -= 1;
                labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
            }
        }
        private void pictureBoxHideOfSteel_Click(object sender, EventArgs e)
        {
            pictureBoxClick(pictureBoxIronBones, pictureBoxHideOfSteel);
        }


        //iron bones
        private void pictureBoxIronBonesUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxHideOfSteel, pictureBoxIronBones);
        }
        private void pictureBoxIronBones_Click(object sender, EventArgs e)
        {
            pictureBoxIronBones.Visible = false;
            beliefsLeft += 1;
            labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
        }


        // Aptiptude
        // literacy
        private void pictureBoxLiteracy_Click(object sender, EventArgs e)
        {
            if (pictureBoxAlchemist.Visible == false && pictureBoxScribe.Visible == false && pictureBoxSanitary.Visible == false && beliefsLeft > 0)
            {
                pictureBoxLiteracy.Visible = false;
                beliefsLeft += 1;
                labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
            }
        }

        private void pictureBoxLiteracyUnder_Click(object sender, EventArgs e)
        {        
            if (beliefsLeft > 0)
            {
                pictureBoxLiteracy.Visible = true;
                beliefsLeft -= 1;
                labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
            }
        }


        //scribe
        private void pictureBoxScribe_Click(object sender, EventArgs e)
        {
            pictureBoxClick(pictureBoxAnthropology, pictureBoxScribe);
        }

        private void pictureBoxScribeUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxLiteracy, pictureBoxScribe);
        }



        //anthropology
        private void pictureBoxAnthropology_Click(object sender, EventArgs e)
        {
            pictureBoxClick(pictureBoxLoremaster, pictureBoxAnthropology);
        }

        private void pictureBoxAnthropologyUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxScribe, pictureBoxAnthropology);
        }

        //loremaster
        private void pictureBoxLoremaster_Click(object sender, EventArgs e)
        {
            pictureBoxLoremaster.Visible = false;
            beliefsLeft += 1;
            labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
        }

        private void pictureBoxLoremasterUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxAnthropology, pictureBoxLoremaster);
        }


        //alchemist
        private void pictureBoxAlchemist_Click(object sender, EventArgs e)
        {
            if (pictureBoxMeasurement.Visible == false && pictureBoxChemist.Visible == false)
            {
                pictureBoxAlchemist.Visible = false;
                beliefsLeft += 1;
                labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
            }
        }

        private void pictureBoxAlchemistUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxLiteracy, pictureBoxAlchemist);
        }

        //chemist
        private void pictureBoxChemist_Click(object sender, EventArgs e)
        {
            pictureBoxClick(pictureBoxScientist, pictureBoxChemist);
        }

        private void pictureBoxChemistUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxAlchemist, pictureBoxChemist);
        }

        //scientist
        private void pictureBoxScientist_Click(object sender, EventArgs e)
        {
            pictureBoxScientist.Visible = false;
            beliefsLeft += 1;
            labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
        }

        private void pictureBoxScientistUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxChemist, pictureBoxScientist);
        }

        //measurement
        private void pictureBoxMeasurement_Click(object sender, EventArgs e)
        {
            pictureBoxClick(pictureBoxBloodNectar, pictureBoxMeasurement);
        }

        private void pictureBoxMeasurementUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxAlchemist, pictureBoxMeasurement);
        }

        //blood nectar
        private void pictureBoxBloodNectar_Click(object sender, EventArgs e)
        {
            pictureBoxBloodNectar.Visible = false;
            beliefsLeft += 1;
            labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
        }

        private void pictureBoxBloodNectarUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxMeasurement, pictureBoxBloodNectar);
        }

        //sanitary
        private void pictureBoxSanitary_Click(object sender, EventArgs e)
        {
            if (pictureBoxDoctor.Visible == false && pictureBoxMedicineMan.Visible == false)
            {
                pictureBoxSanitary.Visible = false;
                beliefsLeft += 1;
                labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
            }
        }

        private void pictureBoxSanitaryUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxLiteracy, pictureBoxSanitary);
        }

        //doctor
        private void pictureBoxDoctor_Click(object sender, EventArgs e)
        {
            pictureBoxClick(pictureBoxSurgeon, pictureBoxDoctor);
        }

        private void pictureBoxDoctorUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxSanitary, pictureBoxDoctor);
        }

        //surgeon
        private void pictureBoxSurgeon_Click(object sender, EventArgs e)
        {
            pictureBoxSurgeon.Visible = false;
            beliefsLeft += 1;
            labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
        }

        private void pictureBoxSurgeonUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxDoctor, pictureBoxSurgeon);
        }

        //medicine man
        private void pictureBoxMedicineMan_Click(object sender, EventArgs e)
        {
            pictureBoxClick(pictureBoxPlagueDoctor, pictureBoxMedicineMan);
        }

        private void pictureBoxMedicineManUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxSanitary, pictureBoxMedicineMan);
        }

        //plague doctor
        private void pictureBoxPlagueDoctor_Click(object sender, EventArgs e)
        {
            pictureBoxPlagueDoctor.Visible = false;
            beliefsLeft += 1;
            labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
        }

        private void pictureBoxPlagueDoctorUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxMedicineMan, pictureBoxPlagueDoctor);
        }


        // FoTF
        //Father
        private void pictureBoxFatherUnder_Click(object sender, EventArgs e)
        {
            if (beliefsLeft > 0)
            {
                pictureBoxFather.Visible = true;
                beliefsLeft -= 1;
                labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
            }
        }
        private void pictureBoxFather_Click(object sender, EventArgs e)
        {
            pictureBoxClick(pictureBoxHonorTheGods, pictureBoxFather);
        }

        private void pictureBoxHonorTheGodsUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxFather, pictureBoxHonorTheGods);
        }
        private void pictureBoxHonorTheGods_Click(object sender, EventArgs e)
        {
            pictureBoxClick(pictureBoxManBeast, pictureBoxHonorTheGods);
        }

        private void pictureBoxManBeastUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxHonorTheGods, pictureBoxManBeast);
        }
        private void pictureBoxManBeast_Click(object sender, EventArgs e)
        {
            pictureBoxClick(pictureBoxFearsomeWolf, pictureBoxManBeast);
        }

        private void pictureBoxFearsomeWolfUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxManBeast, pictureBoxFearsomeWolf);
        }

        private void pictureBoxFearsomeWolf_Click(object sender, EventArgs e)
        {
            pictureBoxFearsomeWolf.Visible = false;
            beliefsLeft += 1;
            labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
        }

        private void pictureBoxMotherUnder_Click(object sender, EventArgs e)
        {
            if (beliefsLeft > 0)
            {
                pictureBoxMother.Visible = true;
                beliefsLeft -= 1;
                labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
            }
        }
        private void pictureBoxMother_Click(object sender, EventArgs e)
        {
            pictureBoxClick(pictureBoxDruid, pictureBoxMother);
        }

        private void pictureBoxDruidUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxMother, pictureBoxDruid);
        }
        private void pictureBoxDruid_Click(object sender, EventArgs e)
        {
            pictureBoxClick(pictureBoxGreatTree, pictureBoxDruid);
        }

        private void pictureBoxGreatTreeUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxDruid, pictureBoxGreatTree);
        }
        private void pictureBoxGreatTree_Click(object sender, EventArgs e)
        {
            pictureBoxClick(pictureBoxWatchfulRaven, pictureBoxGreatTree);
        }

        private void pictureBoxWatchfulRavenUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxGreatTree, pictureBoxWatchfulRaven);
        }

        private void pictureBoxWatchfulRaven_Click(object sender, EventArgs e)
        {
            pictureBoxWatchfulRaven.Visible = false;
            beliefsLeft += 1;
            labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
        }

        private void pictureBoxOldSonUnder_Click(object sender, EventArgs e)
        {
            
            if (beliefsLeft > 0)
            {
                pictureBoxOldSon.Visible = true;
                beliefsLeft -= 1;
                labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
            }
        }
        private void pictureBoxOldSon_Click(object sender, EventArgs e)
        {
            pictureBoxClick(pictureBoxBlackSea, pictureBoxOldSon);
        }

        private void pictureBoxBlackSeaUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxOldSon, pictureBoxBlackSea);
        }
        private void pictureBoxBlackSea_Click(object sender, EventArgs e)
        {
            pictureBoxClick(pictureBoxTasteOfBlood, pictureBoxBlackSea);
        }

        private void pictureBoxTasteOfBloodUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxBlackSea, pictureBoxTasteOfBlood);
        }
        private void pictureBoxTasteOfBlood_Click(object sender, EventArgs e)
        {
            pictureBoxClick(pictureBoxDaringTrout, pictureBoxTasteOfBlood);
        }


        private void pictureBoxDaringTroutUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxTasteOfBlood, pictureBoxDaringTrout);
        }
        private void pictureBoxDaringTrout_Click(object sender, EventArgs e)
        {
            pictureBoxDaringTrout.Visible = false;
            beliefsLeft += 1;
            labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
        }

        private void pictureBoxYoungSonUnder_Click(object sender, EventArgs e)
        {  
            if (beliefsLeft > 0)
            {
                pictureBoxYoungSon.Visible = true;
                beliefsLeft -= 1;
                labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
            }
        }
        private void pictureBoxYoungSon_Click(object sender, EventArgs e)
        {
            pictureBoxClick(pictureBoxTasteOfIron, pictureBoxYoungSon);
        }

        private void pictureBoxTasteOfIronUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxYoungSon, pictureBoxTasteOfIron);
        }
        private void pictureBoxTasteOfIron_Click(object sender, EventArgs e)
        {
            pictureBoxClick(pictureBoxShieldwall, pictureBoxTasteOfIron);
        }

        private void pictureBoxShieldwallUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxTasteOfIron, pictureBoxShieldwall);
        }

        private void pictureBoxShieldwall_Click(object sender, EventArgs e)
        {
            pictureBoxClick(pictureBoxEnduringBear, pictureBoxShieldwall);
        }
        private void pictureBoxEnduringBearUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxShieldwall, pictureBoxEnduringBear);
        }
        private void pictureBoxEnduringBear_Click(object sender, EventArgs e)
        {
            pictureBoxEnduringBear.Visible = false;
            beliefsLeft += 1;
            labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
        }

        private void pictureBoxSisterUnder_Click(object sender, EventArgs e)
        {
            if (beliefsLeft > 0)
            {
                pictureBoxSister.Visible = true;
                beliefsLeft -= 1;
                labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
            }
        }

        private void pictureBoxSister_Click(object sender, EventArgs e)
        {
            pictureBoxClick(pictureBoxWitchDruid, pictureBoxSister);
        }
        private void pictureBoxWitchDruidUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxSister, pictureBoxWitchDruid);
        }
        private void pictureBoxWitchDruid_Click(object sender, EventArgs e)
        {
            pictureBoxClick(pictureBoxShedskin, pictureBoxWitchDruid);
        }

        private void pictureBoxShedskinUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxWitchDruid, pictureBoxShedskin);
        }
        private void pictureBoxShedskin_Click(object sender, EventArgs e)
        {
            pictureBoxClick(pictureBoxDecietfulSnake, pictureBoxShedskin);
        }

        private void pictureBoxDecietfulSnakeUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxShedskin, pictureBoxDecietfulSnake);
        }
        private void pictureBoxDecietfulSnake_Click(object sender, EventArgs e)
        {
            pictureBoxDecietfulSnake.Visible = false;
            beliefsLeft += 1;
            labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
        }

        //FoTD
        //Primevalism

        private void pictureBoxPrimevalismUnder_Click(object sender, EventArgs e)
        {
            if (beliefsLeft > 0)
            {
                pictureBoxPrimevalism.Visible = true;
                beliefsLeft -= 1;
                labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
            }
        }

        private void pictureBoxPrimevalism_Click(object sender, EventArgs e)
        {
            pictureBoxClick(pictureBoxDarkCreature, pictureBoxPrimevalism);
        }

        private void pictureBoxDarkCreatureUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxPrimevalism, pictureBoxDarkCreature);
        }

        private void pictureBoxDarkCreature_Click(object sender, EventArgs e)
        {
            pictureBoxClick(pictureBoxSoothsayer, pictureBoxDarkCreature);
        }

        private void pictureBoxSoothsayerUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxDarkCreature, pictureBoxSoothsayer);
        }

        private void pictureBoxSoothsayer_Click(object sender, EventArgs e)
        {
            if (pictureBoxBloodMoon.Visible == false && pictureBoxDarkEmbrace.Visible == false)
            {
                pictureBoxSoothsayer.Visible = false;
                beliefsLeft += 1;
                labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
            }
        }

        private void pictureBoxBloodMoonUnde_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxSoothsayer, pictureBoxBloodMoon);
        }

        private void pictureBoxDarkEmbraceUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxSoothsayer, pictureBoxDarkEmbrace);
        }

        private void pictureBoxBloodMoon_Click(object sender, EventArgs e)
        {
            pictureBoxBloodMoon.Visible = false;
            beliefsLeft += 1;
            labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
        }

        private void pictureBoxDarkEmbrace_Click(object sender, EventArgs e)
        {
            pictureBoxDarkEmbrace.Visible = false;
            beliefsLeft += 1;
            labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
        }

        private void pictureBoxSurvivalistUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxSoothsayer, pictureBoxSurvivalist);
        }

        private void pictureBoxSurvivalist_Click(object sender, EventArgs e)
        {
            pictureBoxSurvivalist.Visible = false;
            beliefsLeft += 1;
            labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
        }

        //Satanism

        private void pictureBoxSatanismUnder_Click(object sender, EventArgs e)
        {
            if (beliefsLeft > 0)
            {
                pictureBoxSatanism.Visible = true;
                beliefsLeft -= 1;
                labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
            }
        }

        private void pictureBoxSatanism_Click(object sender, EventArgs e)
        {
            if (pictureBoxMurderRepetance.Visible == false && pictureBoxWitch.Visible == false && pictureBoxBlankStare.Visible == false)
            {
                pictureBoxSatanism.Visible = false;
                beliefsLeft += 1;
                labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
            }
        }

        private void pictureBoxWitchUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxSatanism, pictureBoxWitch);
        }

        private void pictureBoxWitch_Click(object sender, EventArgs e)
        {
            pictureBoxClick(pictureBoxHeretic, pictureBoxWitch);
        }

        private void pictureBoxHereticUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxWitch, pictureBoxHeretic);
        }

        private void pictureBoxHeretic_Click(object sender, EventArgs e)
        {
            pictureBoxClick(pictureBoxSorcerer, pictureBoxHeretic);
        }

        private void pictureBoxSorcererUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxHeretic, pictureBoxSorcerer);
            beliefsLeft += 5;
            labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
        }

        private void pictureBoxSorcerer_Click(object sender, EventArgs e)
        {
            if (beliefsLeft >= 5)
            {
                pictureBoxSorcerer.Visible = false;
                beliefsLeft -= 4;
                labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
            }
        }

        private void pictureBoxBlankStareUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxSatanism, pictureBoxBlankStare);
        }

        private void pictureBoxBlankStare_Click(object sender, EventArgs e)
        {
            pictureBoxClick(pictureBoxEncore, pictureBoxBlankStare);
        }

        private void pictureBoxEncoreUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxBlankStare, pictureBoxEncore);
        }

        private void pictureBoxEncore_Click(object sender, EventArgs e)
        {
            if (pictureBoxAssassin.Visible == false && pictureBoxSadism.Visible == false)
            {
                pictureBoxEncore.Visible = false;
                beliefsLeft += 1;
                labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
            }
        }

        private void pictureBoxAssassinUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxEncore, pictureBoxAssassin);
        }

        private void pictureBoxAssassin_Click(object sender, EventArgs e)
        {
            pictureBoxAssassin.Visible = false;
            beliefsLeft += 1;
            labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
        }

        private void pictureBoxSadismUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxEncore, pictureBoxSadism);
        }

        private void pictureBoxSadism_Click(object sender, EventArgs e)
        {
            pictureBoxSadism.Visible = false;
            beliefsLeft += 1;
            labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
        }

        private void pictureBoxMurderArtformUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxSatanism, pictureBoxMurderRepetance);
        }

        private void pictureBoxMurderArtform_Click(object sender, EventArgs e)
        {
            pictureBoxClick(pictureBoxFlamboyance, pictureBoxMurderRepetance);
        }

        private void pictureBoxFlamboyanceUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxMurderRepetance, pictureBoxFlamboyance);
        }

        private void pictureBoxFlamboyance_Click(object sender, EventArgs e)
        {
            if (pictureBoxUnendingDance.Visible == false && pictureBoxImpossibilySkilled.Visible == false) 
            {
                pictureBoxFlamboyance.Visible = false;
                beliefsLeft += 1;
                labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
            }
        }

        private void pictureBoxUnendingDanceUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxFlamboyance, pictureBoxUnendingDance);
        }

        private void pictureBoxUnendingDance_Click(object sender, EventArgs e)
        {
            pictureBoxUnendingDance.Visible = false;
            beliefsLeft += 1;
            labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
        }

        private void pictureBoxImpossibilySkilledUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxFlamboyance, pictureBoxImpossibilySkilled);
        }

        private void pictureBoxImpossibilySkilled_Click(object sender, EventArgs e)
        {
            pictureBoxImpossibilySkilled.Visible = false;
            beliefsLeft += 1;
            labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
        }

        // Faith of the Light
        // Sol
        private void pictureBoxSolOrthUnder_Click(object sender, EventArgs e)
        {
            if (beliefsLeft > 0)
            {
                pictureBoxSolOrth.Visible = true;
                beliefsLeft -= 1;
                labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
            }
        }

        private void pictureBoxSolOrth_Click(object sender, EventArgs e)
        {
            if (pictureBoxMurderRepetance.Visible == false && pictureBoxFleshPrison.Visible == false)
            {
                pictureBoxSolOrth.Visible = false;
                beliefsLeft += 1;
                labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
            }
        }

        private void pictureBoxFleshPrisonUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxSolOrth, pictureBoxFleshPrison);
        }

        private void pictureBoxFleshPrison_Click(object sender, EventArgs e)
        {
            pictureBoxClick(pictureBoxPurityAfloat,pictureBoxFleshPrison);
        }

        private void pictureBoxPurityAfloatUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxFleshPrison, pictureBoxPurityAfloat);
        }

        private void pictureBoxPurityAfloat_Click(object sender, EventArgs e)
        {
            pictureBoxClick(pictureBoxFanatic, pictureBoxPurityAfloat);
        }

        private void pictureBoxFanaticUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxPurityAfloat, pictureBoxFanatic);
        }

        private void pictureBoxFanatic_Click(object sender, EventArgs e)
        {
            pictureBoxFanatic.Visible = false;
            beliefsLeft += 1;
            labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
        }

        private void pictureBoxRepentant_Click(object sender, EventArgs e)
        {
            pictureBoxClick(pictureBoxFlagellant, pictureBoxRepentant);
        }

        private void pictureBoxFlagellant_Click(object sender, EventArgs e)
        {
            pictureBoxClick(pictureBoxExtinctionist, pictureBoxFlagellant);
        }

        private void pictureBoxRepentantUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxSolOrth, pictureBoxRepentant);
        }

        private void pictureBoxFlagellantUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxRepentant, pictureBoxFlagellant);
        }

        private void pictureBoxExtinctionistUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxFlagellant, pictureBoxExtinctionist);
        }

        private void pictureBoxExtinctionist_Click(object sender, EventArgs e)
        {
            pictureBoxExtinctionist.Visible = false;
            beliefsLeft += 1;
            labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
        }

        //Hard glazed
        private void pictureBoxHardGlazedUnder_Click(object sender, EventArgs e)
        {
            if (beliefsLeft > 0)
            {
                pictureBoxHardGlazed.Visible = true;
                beliefsLeft -= 1;
                labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
            }
        }

        private void pictureBoxHardGlazed_Click(object sender, EventArgs e)
        {
            if (pictureBoxDisciple.Visible == false && pictureBoxTheLight.Visible == false)
            {
                pictureBoxHardGlazed.Visible = false;
                beliefsLeft += 1;
                labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
            }
        }

        private void pictureBoxTheLightUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxHardGlazed, pictureBoxTheLight);
        }

        private void pictureBoxTheLight_Click(object sender, EventArgs e)
        {
            pictureBoxClick(pictureBoxBlessedPowder, pictureBoxTheLight);
        }

        private void pictureBoxBlessedPowderUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxTheLight, pictureBoxBlessedPowder);
        }

        private void pictureBoxBlessedPowder_Click(object sender, EventArgs e)
        {
            pictureBoxClick(pictureBoxTheManifesto, pictureBoxBlessedPowder);
        }

        private void pictureBoxTheManifestoUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxBlessedPowder, pictureBoxTheManifesto);
        }

        private void pictureBoxTheManifesto_Click(object sender, EventArgs e)
        {
            pictureBoxTheManifesto.Visible = false;
            beliefsLeft += 1;
            labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
        }

        private void pictureBoxDiscipleUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxHardGlazed, pictureBoxDisciple);
        }

        private void pictureBoxDisciple_Click(object sender, EventArgs e)
        {
            pictureBoxClick(pictureBoxAcolyte, pictureBoxDisciple);
        }

        private void pictureBoxAcolyteUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxDisciple, pictureBoxAcolyte);
        }

        private void pictureBoxAcolyte_Click(object sender, EventArgs e)
        {
            pictureBoxClick(pictureBoxEmissary, pictureBoxAcolyte);
        }

        private void pictureBoxEmissaryUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxAcolyte, pictureBoxEmissary);
        }

        private void pictureBoxEmissary_Click(object sender, EventArgs e)
        {
            pictureBoxEmissary.Visible = false;
            beliefsLeft += 1;
            labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
        }

        // Voltism

        private void pictureBoxVoltismUnder_Click(object sender, EventArgs e)
        {
            if (beliefsLeft > 0)
            {
                pictureBoxVoltism.Visible = true;
                beliefsLeft -= 1;
                labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
            }
        }

        private void pictureBoxVoltism_Click(object sender, EventArgs e)
        {
            if (pictureBoxWireTherapy.Visible == false && pictureBoxWriggleEel.Visible == false)
            {
                pictureBoxVoltism.Visible = false;
                beliefsLeft += 1;
                labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
            }
        }

        private void pictureBoxWriggleEelUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxVoltism,pictureBoxWriggleEel);
        }

        private void pictureBoxWriggleEel_Click(object sender, EventArgs e)
        {
            pictureBoxClick(pictureBoxYellowBlack, pictureBoxWriggleEel);
        }

        private void pictureBoxYellowBlackUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxWriggleEel,pictureBoxYellowBlack);
        }

        private void pictureBoxYellowBlack_Click(object sender, EventArgs e)
        {
            pictureBoxClick(pictureBoxTheStorm, pictureBoxYellowBlack);
        }

        private void pictureBoxTheStormUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxYellowBlack,pictureBoxTheStorm);
        }

        private void pictureBoxTheStorm_Click(object sender, EventArgs e)
        {
            pictureBoxTheStorm.Visible = false;
            beliefsLeft += 1;
            labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
        }

        private void pictureBoxWireTherapy_Click(object sender, EventArgs e)
        {
            pictureBoxClick(pictureBoxVoltism, pictureBoxWireTherapy);
        }

        private void pictureBoxWireTherapyUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxVoltism,pictureBoxWireTherapy);
        }

        private void pictureBox37pictureBoxJacobsLadder_Click(object sender, EventArgs e)
        {
            pictureBoxClick(pictureBoxWireTherapy, pictureBoxJacobsLadder);
        }

        private void pictureBoxJacobsLadderUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxWireTherapy,pictureBoxJacobsLadder);
        }

        private void pictureBoxParadoxRiddleUnder_Click(object sender, EventArgs e)
        {
            pictureBoxUnderClick(pictureBoxJacobsLadder,pictureBoxParadoxRiddle);
        }

        private void pictureBoxParadoxRiddle_Click(object sender, EventArgs e)
        {
            pictureBoxParadoxRiddle.Visible = false;
            beliefsLeft += 1;
            labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
        }


        // Picture Box Methods
        private void pictureBoxUnderClick(PictureBox previousBelief, PictureBox currentBelief)
        {
            if (previousBelief.Visible == true && beliefsLeft > 0)
            {
                currentBelief.Visible = true;
                beliefsLeft -= 1;
                labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);

            }
            else
            {
                MessageBox.Show("Please take the prerequisite");
            }
        }

        private void pictureBoxClick(PictureBox nextBelief, PictureBox currentBelief)
        {
            if (nextBelief.Visible == false)
            {
                currentBelief.Visible = false;
                beliefsLeft += 1;
                labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);
            }
        }

        // Paint arrows
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Brushes.Black, 5);
            p.StartCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            g.DrawLine(p, 70, 161, 70, 145); // Half to Blade
            g.DrawLine(p, 70, 221, 70, 205); // Blade to Bill

            g.DrawLine(p, 130, 161, 130, 145); // Parry to Repulsive

            g.DrawLine(p, 190, 101, 190, 85); // Fighter to Wrestle
            g.DrawLine(p, 190, 161, 190, 145); // Wrestle to Warrior
            g.DrawLine(p, 190, 221, 190, 205); // Warrior to Master at arms

            g.DrawLine(p, 250, 161, 250, 145); // Deflection to Sidestep

            g.DrawLine(p, 310, 161, 310, 145); // Strength to Might
            g.DrawLine(p, 310, 221, 310, 205); // Might to Unrelenting
        }


        // Hover over tool tip
        private void pictureBoxFighterUnder_MouseMove(object sender, MouseEventArgs e)
        {
            richTextBox1.Visible = true;
            toolTipHover();
        }

        private void pictureBoxFighterUnder_MouseHover(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
            toolTipHover();
        }

        private void pictureBoxFighterUnder_MouseLeave(object sender, EventArgs e)
        {
            richTextBox1.Visible = false;
        }

        private void toolTipHover()
        {
            Point p1 = MousePosition;
            Point p2 = PointToClient(p1);
            richTextBox1.Location = new Point(p2.X + 10, p2.Y + 10);
        }




        // Custom font for labels
        private void customFontInit()
        {
            string filename = "temp.a";
            File.WriteAllBytes(filename, Resources.van_dijck_mt_std);
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(filename);

            labelProwess.Font = new Font(pfc.Families[0], 16);
            labelBrutality.Font = new Font(pfc.Families[0], 16);
            labelIngenuity.Font = new Font(pfc.Families[0], 16);
            labelFortitude.Font = new Font(pfc.Families[0], 16);
            labelFortune.Font = new Font(pfc.Families[0], 16);
            labelAptitude.Font = new Font(pfc.Families[0], 16);
            labelLitheness.Font = new Font(pfc.Families[0], 16);
            labelFotF.Font = new Font(pfc.Families[0], 16);
            labelFotD.Font = new Font(pfc.Families[0], 16);
            labelFotL.Font = new Font(pfc.Families[0], 16);
            labelBeliefsLeft.Font = new Font(pfc.Families[0], 13);


        }


        // Checkboxes
        private void checkBoxFotL_Click(object sender, EventArgs e)
        {
            checkBoxFotF.Checked = false;
            checkBoxFotD.Checked = false;

            if (checkBoxFotL.Checked)
            {
                pictureBoxSolOrthUnder.Visible = pictureBoxRepentantUnder.Visible = pictureBoxFlagellantUnder.Visible = pictureBoxExtinctionistUnder.Visible = pictureBoxFleshPrisonUnder.Visible = pictureBoxPurityAfloatUnder.Visible = pictureBoxFanaticUnder.Visible = pictureBoxHardGlazedUnder.Visible = pictureBoxDiscipleUnder.Visible = pictureBoxAcolyteUnder.Visible = pictureBoxEmissaryUnder.Visible = pictureBoxTheLightUnder.Visible = pictureBoxBlessedPowderUnder.Visible = pictureBoxTheManifestoUnder.Visible = pictureBoxVoltismUnder.Visible = pictureBoxWireTherapyUnder.Visible = pictureBoxJacobsLadderUnder.Visible = pictureBoxParadoxRiddleUnder.Visible = pictureBoxWriggleEelUnder.Visible = pictureBoxYellowBlackUnder.Visible = pictureBoxTheStormUnder.Visible = labelFotL.Visible = true;
                pictureBoxSatanismUnder.Visible = pictureBoxWitchUnder.Visible = pictureBoxHereticUnder.Visible = pictureBoxSorcererUnder.Visible = pictureBoxBlankStareUnder.Visible = pictureBoxEncoreUnder.Visible = pictureBoxAssassinUnder.Visible = pictureBoxSadismUnder.Visible = pictureBoxMurderArtformUnder.Visible = pictureBoxFlamboyanceUnder.Visible = pictureBoxUnendingDanceUnder.Visible = pictureBoxImpossibilySkilledUnder.Visible = pictureBoxPrimevalismUnder.Visible = pictureBoxDarkCreatureUnder.Visible = pictureBoxDarkEmbraceUnder.Visible = pictureBoxSoothsayerUnder.Visible = pictureBoxBloodMoonUnder.Visible = pictureBoxSurvivalistUnder.Visible = labelFotD.Visible = false;
                pictureBoxFatherUnder.Visible = pictureBoxHonorTheGodsUnder.Visible = pictureBoxManBeastUnder.Visible = pictureBoxFearsomeWolfUnder.Visible = pictureBoxMotherUnder.Visible = pictureBoxDruidUnder.Visible = pictureBoxGreatTreeUnder.Visible = pictureBoxWatchfulRavenUnder.Visible = pictureBoxOldSonUnder.Visible = pictureBoxBlackSeaUnder.Visible = pictureBoxTasteOfBloodUnder.Visible = pictureBoxDaringTroutUnder.Visible = pictureBoxYoungSonUnder.Visible = pictureBoxTasteOfIronUnder.Visible = pictureBoxShieldwallUnder.Visible = pictureBoxEnduringBearUnder.Visible = pictureBoxSisterUnder.Visible = pictureBoxWitchDruidUnder.Visible = pictureBoxShedskinUnder.Visible = pictureBoxDecietfulSnakeUnder.Visible = labelFotF.Visible = false;
            }
            else
            {
                pictureBoxSolOrthUnder.Visible = pictureBoxRepentantUnder.Visible = pictureBoxFlagellantUnder.Visible = pictureBoxExtinctionistUnder.Visible = pictureBoxFleshPrisonUnder.Visible = pictureBoxPurityAfloatUnder.Visible = pictureBoxFanaticUnder.Visible = pictureBoxHardGlazedUnder.Visible = pictureBoxDiscipleUnder.Visible = pictureBoxAcolyteUnder.Visible = pictureBoxEmissaryUnder.Visible = pictureBoxTheLightUnder.Visible = pictureBoxBlessedPowderUnder.Visible = pictureBoxTheManifestoUnder.Visible = pictureBoxVoltismUnder.Visible = pictureBoxWireTherapyUnder.Visible = pictureBoxJacobsLadderUnder.Visible = pictureBoxParadoxRiddleUnder.Visible = pictureBoxWriggleEelUnder.Visible = pictureBoxYellowBlackUnder.Visible = pictureBoxTheStormUnder.Visible = labelFotL.Visible = false;
            }
        }

        private void checkBoxFotF_Click(object sender, EventArgs e)
        {
            checkBoxFotD.Checked = false;
            checkBoxFotL.Checked = false;

            if (checkBoxFotF.Checked)
            {
                pictureBoxFatherUnder.Visible = pictureBoxHonorTheGodsUnder.Visible = pictureBoxManBeastUnder.Visible = pictureBoxFearsomeWolfUnder.Visible = pictureBoxMotherUnder.Visible = pictureBoxDruidUnder.Visible = pictureBoxGreatTreeUnder.Visible = pictureBoxWatchfulRavenUnder.Visible = pictureBoxOldSonUnder.Visible = pictureBoxBlackSeaUnder.Visible = pictureBoxTasteOfBloodUnder.Visible = pictureBoxDaringTroutUnder.Visible = pictureBoxYoungSonUnder.Visible = pictureBoxTasteOfIronUnder.Visible = pictureBoxShieldwallUnder.Visible = pictureBoxEnduringBearUnder.Visible = pictureBoxSisterUnder.Visible = pictureBoxWitchDruidUnder.Visible = pictureBoxShedskinUnder.Visible = pictureBoxDecietfulSnakeUnder.Visible = labelFotF.Visible = true;
                pictureBoxSatanismUnder.Visible = pictureBoxWitchUnder.Visible = pictureBoxHereticUnder.Visible = pictureBoxSorcererUnder.Visible = pictureBoxBlankStareUnder.Visible = pictureBoxEncoreUnder.Visible = pictureBoxAssassinUnder.Visible = pictureBoxSadismUnder.Visible = pictureBoxMurderArtformUnder.Visible = pictureBoxFlamboyanceUnder.Visible = pictureBoxUnendingDanceUnder.Visible = pictureBoxImpossibilySkilledUnder.Visible = pictureBoxPrimevalismUnder.Visible = pictureBoxDarkCreatureUnder.Visible = pictureBoxDarkEmbraceUnder.Visible = pictureBoxSoothsayerUnder.Visible = pictureBoxBloodMoonUnder.Visible = pictureBoxSurvivalistUnder.Visible = labelFotD.Visible = false;
                pictureBoxSolOrthUnder.Visible = pictureBoxRepentantUnder.Visible = pictureBoxFlagellantUnder.Visible = pictureBoxExtinctionistUnder.Visible = pictureBoxFleshPrisonUnder.Visible = pictureBoxPurityAfloatUnder.Visible = pictureBoxFanaticUnder.Visible = pictureBoxHardGlazedUnder.Visible = pictureBoxDiscipleUnder.Visible = pictureBoxAcolyteUnder.Visible = pictureBoxEmissaryUnder.Visible = pictureBoxTheLightUnder.Visible = pictureBoxBlessedPowderUnder.Visible = pictureBoxTheManifestoUnder.Visible = pictureBoxVoltismUnder.Visible = pictureBoxWireTherapyUnder.Visible = pictureBoxJacobsLadderUnder.Visible = pictureBoxParadoxRiddleUnder.Visible = pictureBoxWriggleEelUnder.Visible = pictureBoxYellowBlackUnder.Visible = pictureBoxTheStormUnder.Visible = labelFotL.Visible = false;
            }
            else
            {
                pictureBoxFatherUnder.Visible = pictureBoxHonorTheGodsUnder.Visible = pictureBoxManBeastUnder.Visible = pictureBoxFearsomeWolfUnder.Visible = pictureBoxMotherUnder.Visible = pictureBoxDruidUnder.Visible = pictureBoxGreatTreeUnder.Visible = pictureBoxWatchfulRavenUnder.Visible = pictureBoxOldSonUnder.Visible = pictureBoxBlackSeaUnder.Visible = pictureBoxTasteOfBloodUnder.Visible = pictureBoxDaringTroutUnder.Visible = pictureBoxYoungSonUnder.Visible = pictureBoxTasteOfIronUnder.Visible = pictureBoxShieldwallUnder.Visible = pictureBoxEnduringBearUnder.Visible = pictureBoxSisterUnder.Visible = pictureBoxWitchDruidUnder.Visible = pictureBoxShedskinUnder.Visible = pictureBoxDecietfulSnakeUnder.Visible = labelFotF.Visible = false;
            }
        }

        private void checkBoxFotD_Click(object sender, EventArgs e)
        {
            checkBoxFotF.Checked = false;
            checkBoxFotL.Checked = false;

            if (checkBoxFotD.Checked)
            {
                pictureBoxSatanismUnder.Visible = pictureBoxWitchUnder.Visible = pictureBoxHereticUnder.Visible = pictureBoxSorcererUnder.Visible = pictureBoxBlankStareUnder.Visible = pictureBoxEncoreUnder.Visible = pictureBoxAssassinUnder.Visible = pictureBoxSadismUnder.Visible = pictureBoxMurderArtformUnder.Visible = pictureBoxFlamboyanceUnder.Visible = pictureBoxUnendingDanceUnder.Visible = pictureBoxImpossibilySkilledUnder.Visible = pictureBoxPrimevalismUnder.Visible = pictureBoxDarkCreatureUnder.Visible = pictureBoxDarkEmbraceUnder.Visible = pictureBoxSoothsayerUnder.Visible = pictureBoxBloodMoonUnder.Visible = pictureBoxSurvivalistUnder.Visible = labelFotD.Visible = true;
                pictureBoxFatherUnder.Visible = pictureBoxHonorTheGodsUnder.Visible = pictureBoxManBeastUnder.Visible = pictureBoxFearsomeWolfUnder.Visible = pictureBoxMotherUnder.Visible = pictureBoxDruidUnder.Visible = pictureBoxGreatTreeUnder.Visible = pictureBoxWatchfulRavenUnder.Visible = pictureBoxOldSonUnder.Visible = pictureBoxBlackSeaUnder.Visible = pictureBoxTasteOfBloodUnder.Visible = pictureBoxDaringTroutUnder.Visible = pictureBoxYoungSonUnder.Visible = pictureBoxTasteOfIronUnder.Visible = pictureBoxShieldwallUnder.Visible = pictureBoxEnduringBearUnder.Visible = pictureBoxSisterUnder.Visible = pictureBoxWitchDruidUnder.Visible = pictureBoxShedskinUnder.Visible = pictureBoxDecietfulSnakeUnder.Visible = labelFotF.Visible = false;
                pictureBoxSolOrthUnder.Visible = pictureBoxRepentantUnder.Visible = pictureBoxFlagellantUnder.Visible = pictureBoxExtinctionistUnder.Visible = pictureBoxFleshPrisonUnder.Visible = pictureBoxPurityAfloatUnder.Visible = pictureBoxFanaticUnder.Visible = pictureBoxHardGlazedUnder.Visible = pictureBoxDiscipleUnder.Visible = pictureBoxAcolyteUnder.Visible = pictureBoxEmissaryUnder.Visible = pictureBoxTheLightUnder.Visible = pictureBoxBlessedPowderUnder.Visible = pictureBoxTheManifestoUnder.Visible = pictureBoxVoltismUnder.Visible = pictureBoxWireTherapyUnder.Visible = pictureBoxJacobsLadderUnder.Visible = pictureBoxParadoxRiddleUnder.Visible = pictureBoxWriggleEelUnder.Visible = pictureBoxYellowBlackUnder.Visible = pictureBoxTheStormUnder.Visible = labelFotL.Visible = false;
            }
            else
            {
                pictureBoxSatanismUnder.Visible = pictureBoxWitchUnder.Visible = pictureBoxHereticUnder.Visible = pictureBoxSorcererUnder.Visible = pictureBoxBlankStareUnder.Visible = pictureBoxEncoreUnder.Visible = pictureBoxAssassinUnder.Visible = pictureBoxSadismUnder.Visible = pictureBoxMurderArtformUnder.Visible = pictureBoxFlamboyanceUnder.Visible = pictureBoxUnendingDanceUnder.Visible = pictureBoxImpossibilySkilledUnder.Visible = pictureBoxPrimevalismUnder.Visible = pictureBoxDarkCreatureUnder.Visible = pictureBoxDarkEmbraceUnder.Visible = pictureBoxSoothsayerUnder.Visible = pictureBoxBloodMoonUnder.Visible = pictureBoxSurvivalistUnder.Visible = labelFotD.Visible = false;
            }


        }

        private void buttonResetBeliefs_Click(object sender, EventArgs e)
        {
            pictureBoxFighter.Visible = pictureBoxWrestle.Visible = pictureBoxWarrior.Visible = pictureBoxMasterAtArms.Visible = pictureBoxHalfSwordSway.Visible = pictureBoxBladeMaster.Visible = pictureBoxBillman.Visible = pictureBoxParrying.Visible = pictureBoxRepulsive.Visible = pictureBoxDeflection.Visible = pictureBoxSidestep.Visible = pictureBoxStrength.Visible = pictureBoxMight.Visible = pictureBoxUnrelenting.Visible = pictureBoxSavage.Visible = pictureBoxPrimeval.Visible = pictureBoxHeadTaker.Visible = pictureBoxHeartEater.Visible = pictureBoxBestial.Visible = pictureBoxSavageAnimal.Visible = pictureBoxFortunate.Visible = pictureBoxLucky.Visible = pictureBoxFavored.Visible = pictureBoxTalented.Visible = pictureBoxGifted.Visible = pictureBoxJOAT.Visible = pictureBoxNimble.Visible = pictureBoxSkyFidget.Visible = pictureBoxSafecracker.Visible = pictureBoxThief.Visible = pictureBoxDexterity.Visible = pictureBoxSwift.Visible = pictureBoxEvasion.Visible = pictureBoxIngenious.Visible = pictureBoxCraftsman.Visible = pictureBoxMechanic.Visible = pictureBoxArtisan.Visible = pictureBoxSmith.Visible = pictureBoxBlacksmith.Visible = pictureBoxMasterBlacksmith.Visible = pictureBoxScourRust.Visible = pictureBoxFortifiedPlate.Visible = pictureBoxPowderSteel.Visible = pictureBoxPistolier.Visible = pictureBoxMarksman.Visible = pictureBoxCookist.Visible = pictureBoxCulinarian.Visible = pictureBoxLiteracy.Visible = pictureBoxScribe.Visible = pictureBoxAnthropology.Visible = pictureBoxLoremaster.Visible = pictureBoxSanitary.Visible = pictureBoxDoctor.Visible = pictureBoxSurgeon.Visible = pictureBoxMedicineMan.Visible = pictureBoxPlagueDoctor.Visible = pictureBoxAlchemist.Visible = pictureBoxChemist.Visible = pictureBoxScientist.Visible = pictureBoxMeasurement.Visible = pictureBoxBloodNectar.Visible = pictureBoxAsceticism.Visible = pictureBoxOutlasting.Visible = pictureBoxPrudence.Visible = pictureBoxComposure.Visible = pictureBoxRepudation.Visible = pictureBoxDefender.Visible = pictureBoxWarden.Visible = pictureBoxHauberk.Visible = pictureBoxUnburdened.Visible = pictureBoxPerserverance.Visible = pictureBoxPlentyToSpill.Visible = pictureBoxUnyielding.Visible = pictureBoxHideOfSteel.Visible = pictureBoxIronBones.Visible = pictureBoxFather.Visible = pictureBoxHonorTheGods.Visible = pictureBoxManBeast.Visible = pictureBoxFearsomeWolf.Visible = pictureBoxMother.Visible = pictureBoxDruid.Visible = pictureBoxGreatTree.Visible = pictureBoxWatchfulRaven.Visible = pictureBoxOldSon.Visible = pictureBoxBlackSea.Visible = pictureBoxTasteOfBlood.Visible = pictureBoxDaringTrout.Visible = pictureBoxYoungSon.Visible = pictureBoxTasteOfIron.Visible = pictureBoxShieldwall.Visible = pictureBoxEnduringBear.Visible = pictureBoxSister.Visible = pictureBoxWitchDruid.Visible = pictureBoxShedskin.Visible = pictureBoxDecietfulSnake.Visible = pictureBoxPrimevalism.Visible = pictureBoxDarkCreature.Visible = pictureBoxSoothsayer.Visible = pictureBoxSurvivalist.Visible = pictureBoxDarkEmbrace.Visible = pictureBoxBloodMoon.Visible = pictureBoxSatanism.Visible = pictureBoxWitch.Visible = pictureBoxHeretic.Visible = pictureBoxSorcerer.Visible = pictureBoxMurderRepetance.Visible = pictureBoxFlamboyance.Visible = pictureBoxUnendingDance.Visible = pictureBoxImpossibilySkilled.Visible = pictureBoxBlankStare.Visible = pictureBoxEncore.Visible = pictureBoxAssassin.Visible = pictureBoxSadism.Visible = pictureBoxSolOrth.Visible = pictureBoxRepentant.Visible = pictureBoxFlagellant.Visible = pictureBoxExtinctionist.Visible = pictureBoxFleshPrison.Visible = pictureBoxPurityAfloat.Visible = pictureBoxFanatic.Visible = pictureBoxHardGlazed.Visible = pictureBoxDisciple.Visible = pictureBoxAcolyte.Visible = pictureBoxEmissary.Visible = pictureBoxTheLight.Visible = pictureBoxBlessedPowder.Visible = pictureBoxTheManifesto.Visible = pictureBoxVoltism.Visible = pictureBoxWireTherapy.Visible = pictureBoxJacobsLadder.Visible = pictureBoxParadoxRiddle.Visible = pictureBoxWriggleEel.Visible = pictureBoxYellowBlack.Visible = pictureBoxTheStorm.Visible = false;
            beliefsLeft = 40;
            labelBeliefsLeft.Text = ("Beliefs Left: " + beliefsLeft);

        }

        private void customRichTextBoxInit()
        {
            richTextBox1.BackColor = Color.FromArgb(71, 26, 29);
            richTextBox1.ForeColor = Color.FromArgb(232, 95, 104);
            richTextBox1.BorderStyle = BorderStyle.FixedSingle;
            richTextBox1.Rtf = @"{\rtf1\ansi \b " + fighterToolTipInfo +"}";
        }

       
    }

}
