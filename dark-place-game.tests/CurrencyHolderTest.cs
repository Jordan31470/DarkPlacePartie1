using System; 
using Xunit; 
 
namespace dark_place_game.tests {          
    /// Cette classe contient tout un ensemble de tests unitaires pour la classe CurrencyHolder     
    public class CurrencyHolderTest     {         
        public static readonly int EXEMPLE_CAPACITE_VALIDE = 2748;         
        public static readonly int EXEMPLE_CONTENANCE_INITIALE_VALIDE = 978;         
        public static readonly string EXEMPLE_NOM_MONNAIE_VALIDE = "Brouzouf"; 
 
        [Fact]         
        public void VraiShouldBeTrue()         {             
            var vrai = false;             
            Assert.True(vrai, "Erreur, vrai vaut false. Le test est volontairement mal écrit, corrigez le.");         
            } 
 
        [Fact]         
        public void CurrencyHolderCreatedWithInitialCurrentAmountOf10ShouldContain10Currency()         {             
            var ch = new CurrencyHolder(EXEMPLE_NOM_MONNAIE_VALIDE,EXEMPLE_CAPACITE_VALIDE , 10);             
            var result = ch.CurrentAmount == 10;             
            Assert.True(result);         
            } 
 
        [Fact]         
        public void CurrencyHolderCreatedWithInitialCurrentAmountOf25ShouldContain25Currency()         {             
            var ch = new CurrencyHolder(EXEMPLE_NOM_MONNAIE_VALIDE, EXEMPLE_CAPACITE_VALIDE, 25);             
            var result = ch.CurrentAmount == 25;             
            Assert.True(result);         
            } 
 
        [Fact]         
        public void CurrencyHolderCreatedWithInitialCurrentAmountOf0ShouldContain0Currency()         {             
            var ch = new CurrencyHolder(EXEMPLE_NOM_MONNAIE_VALIDE,EXEMPLE_CAPACITE_VALIDE, 0);             
            var result = ch.CurrentAmount == 0;             
            Assert.True(result);         
            } 
 
        [Fact]         public void CreatingCurrencyHolderWithNegativeContentThrowExeption()         
        {             
            // Petite subtilité : pour tester les levées d'exeption en c# on est obligé d'utiliser un concept un             
        // sans entrer dans le détail pour déclarer une lambda respectez la syntaxe ci dessous, pour rédiger             
        Action mauvaisAppel = () => new CurrencyHolder(EXEMPLE_NOM_MONNAIE_VALIDE,EXEMPLE_CAPACITE_VALIDE ,             
        Assert.Throws<ArgumentException>(mauvaisAppel); 
        } 
 
        [Fact]         
        public void CreatingCurrencyHolderWithNullNameThrowExeption()         
        {             
            // Petite subtilité : pour tester les levées d'exeption en c# on est obligé d'utiliser un concept un             
            // sans entrer dans le détail pour déclarer une lambda respectez la syntaxe ci dessous, pour rédiger             
            Action mauvaisAppel = () => new CurrencyHolder(null,EXEMPLE_CAPACITE_VALIDE , EXEMPLE_CONTENANCE_INIT            
            Assert.Throws<ArgumentException>(mauvaisAppel);         
            } 
 
        [Fact]         
        public void CreatingCurrencyHolderWithEmptyNameThrowExeption()        
         {             
            // Petite subtilité : pour tester les levées d'exeption en c# on est obligé d'utiliser un concept un             
            // sans entrer dans le détail pour déclarer une lambda respectez la syntaxe ci dessous, pour rédiger             
            Action mauvaisAppel = () => new CurrencyHolder("",EXEMPLE_CAPACITE_VALIDE , EXEMPLE_CONTENANCE_INITIA            
            Assert.Throws<ArgumentException>(mauvaisAppel);         
            } 
 
        /** #TODO_ETAPE_4         
        [Fact]         
        public void BrouzoufIsAValidCurrencyName ()         
        {             
            // A vous d'écrire un test qui vérife qu'on peut créer un CurrencyHolder contenant une monnaie dont l        
            } 
 
        [Fact]         
        public void DollardIsAValidCurrencyName ()         
        {             // A vous d'écrire un test qui vérife qu'on peut créer un CurrencyHolder contenant une monnaie dont l        } 
 
        [Fact]         
        public void TestPut10CurrencyInNonFullCurrencyHolder()         
        {             
            // A vous d'écrire un test qui vérifie que si on ajoute via la methode put 10 currency à un sac a moi        } 
 
        [Fact]         
        public void TestPut10CurrencyInNearlyFullCurrencyHolder()         
        {             
            // A vous d'écrire un test qui vérifie que si on ajoute via la methode put 10 currency à un sac quasi        } 
 
        [Fact]         
        public void CreatingCurrencyHolderWithNameShorterThan4CharacterThrowExeption()         {             
            // A vous d'écrire un test qui doit échouer s'il es possible de créer un CurrencyHolder dont Le Nom D        } 
		[Fact]         
        public void WithdrawMoreThanCurrentAmountInCurrencyHolderThrowExeption()      
        
    } } 