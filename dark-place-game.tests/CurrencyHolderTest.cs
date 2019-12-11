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
            var vrai = true;             
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
 
        [Fact]         
        public void CreatingCurrencyHolderWithNegativeContentThrowExeption()         
        {             
            // Petite subtilité : pour tester les levées d'exeption en c# on est obligé d'utiliser un concept un             
        // sans entrer dans le détail pour déclarer une lambda respectez la syntaxe ci dessous, pour rédiger             
        Action mauvaisAppel = () => new CurrencyHolder(EXEMPLE_NOM_MONNAIE_VALIDE,EXEMPLE_CAPACITE_VALIDE ,-10);             
        Assert.Throws<ArgumentException>(mauvaisAppel);
       
        
        } 
 
        [Fact]         
        public void CreatingCurrencyHolderWithNullNameThrowExeption()         
        {             
            // Petite subtilité : pour tester les levées d'exeption en c# on est obligé d'utiliser un concept un             
            // sans entrer dans le détail pour déclarer une lambda respectez la syntaxe ci dessous, pour rédiger             
            Action mauvaisAppel = () => new CurrencyHolder(null,EXEMPLE_CAPACITE_VALIDE , EXEMPLE_CONTENANCE_INITIALE_VALIDE);            
            Assert.Throws<ArgumentException>(mauvaisAppel);         
            } 
 
        [Fact]
        public void CreatingCurrencyHolderWithEmptyNameThrowExeption()
        {
            // Petite subtilité : pour tester les levées d'exeption en c# on est obligé d'utiliser un concept un peu exotique : les expression lambda.
            // sans entrer dans le détail pour déclarer une lambda respectez la syntaxe ci dessous, pour rédiger des tests unitaires elle devrais vous suffire.
            Action mauvaisAppel = () => new CurrencyHolder("",EXEMPLE_CAPACITE_VALIDE , EXEMPLE_CONTENANCE_INITIALE_VALIDE);
            Assert.Throws<ArgumentException>(mauvaisAppel);
        } 
 
                
        [Fact]         
        public void BrouzoufIsAValidCurrencyName ()         
        {             
        // A vous d'écrire un test qui vérife qu'on peut créer un CurrencyHolder contenant une monnaie dont l
        var ch = new CurrencyHolder("Brouzouf",EXEMPLE_CAPACITE_VALIDE, 0);  
        Assert.True(ch.CurrencyName == "Brouzouf");       
        } 
 
        [Fact]         
        public void DollardIsAValidCurrencyName () 
        {             
        // A vous d'écrire un test qui vérife qu'on peut créer un CurrencyHolder contenant une monnaie dont l 
        var ch = new CurrencyHolder("Dollard",EXEMPLE_CAPACITE_VALIDE, 0);
        Assert.True(ch.CurrencyName == "Dollard");          
        } 
 
        [Fact]         
        public void TestPut10CurrencyInNonFullCurrencyHolder() {
        var ch = new CurrencyHolder("Dollard",EXEMPLE_CAPACITE_VALIDE,250);    
        ch.Store(10);
        Assert.True(ch.CurrentAmount == 260);
                         
        // A vous d'écrire un test qui vérifie que si on ajoute via la methode put 10 currency à un sac a moi

        } 
 
        [Fact]         
        public void TestPut10CurrencyInNearlyFullCurrencyHolder()         
        {
            Action mauvaisAppel = () => {
            var ch = new CurrencyHolder(EXEMPLE_NOM_MONNAIE_VALIDE,250,200);
            ch.Store(60);
            };
            Assert.Throws<ArgumentException>(mauvaisAppel);

        // A vous d'écrire un test qui vérifie que si on ajoute via la methode put 10 currency à un sac quasi        
        } 
 
        [Fact]         
        public void CreatingCurrencyHolderWithNameShorterThan4CharacterThrowExeption() 
        {
            Action mauvaisAppel = () => new CurrencyHolder("EU",EXEMPLE_CAPACITE_VALIDE , EXEMPLE_CONTENANCE_INITIALE_VALIDE);
            Assert.Throws<ArgumentException>(mauvaisAppel);



        // A vous d'écrire un test qui doit échouer s'il es possible de créer un CurrencyHolder dont Le Nom D       
        } 
		[Fact]         
        public void WithdrawMoreThanCurrentAmountInCurrencyHolderThrowExeption()        {
            Action mauvaisAppel = () => {
            var ch = new CurrencyHolder(EXEMPLE_NOM_MONNAIE_VALIDE,250,200);
            ch.Withdraw(-60);
            };
            Assert.Throws<CantWitchDrawMoreThanCurrentAmountExeption>(mauvaisAppel);
                // A vous d'écrire un test qui vérifie que retirer (methode withdraw) une quantité negative de curren            
                // Asruce : dans ce cas prévu avant même de pouvoir compiler le test, vous allez être obligé de créer        }         #TODO_ETAPE_4 */ 
 
        }  
       
    
    } 
    }

