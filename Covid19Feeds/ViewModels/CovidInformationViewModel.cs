using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Covid19Feeds.Models;

namespace Covid19Feeds.ViewModels
{
    public class CovidInformationViewModel:BaseViewModel
    {
        public Lazy<ObservableCollection<FAQModel>> QusetionList { get; set; }
        public CovidInformationViewModel()
        {
            QusetionList = new Lazy<ObservableCollection<FAQModel>>();
        }
        public async Task LoadFaqs()
        {

          
            QusetionList.Value.Add(

            new FAQModel()
            {
                Question = "What is a coronavirus?",
                Answer = "Coronaviruses are a large family of viruses which may cause illness in animals or humans.  In humans, several coronaviruses are known to cause respiratory infections ranging from the common cold to more severe diseases such as Middle East Respiratory Syndrome (MERS) and Severe Acute Respiratory Syndrome (SARS). The most recently discovered coronavirus causes coronavirus disease COVID-19."
            });



            QusetionList.Value.Add(

           new FAQModel()
           {
               Question = "What is COVID-19?",
               Answer = "COVID-19 is the infectious disease caused by the most recently discovered coronavirus. This new virus and disease were unknown before the outbreak began in Wuhan, China, in December 2019."
           });


            QusetionList.Value.Add(

           new FAQModel()
           {
               Question = "What are the symptoms of COVID-19?",
               Answer = "The most common symptoms of COVID-19 are fever, tiredness, and dry cough. Some patients may have aches and pains, nasal congestion, runny nose, sore throat or diarrhea. These symptoms are usually mild and begin gradually. Some people become infected but don’t develop any symptoms and don't feel unwell. Most people (about 80%) recover from the disease without needing special treatment. Around 1 out of every 6 people who gets COVID-19 becomes seriously ill and develops difficulty breathing. Older people, and those with underlying medical problems like high blood pressure, heart problems or diabetes, are more likely to develop serious illness. People with fever, cough and difficulty breathing should seek medical attention."
           });



            QusetionList.Value.Add(

           new FAQModel()
           {
               Question = "How does COVID-19 spread?",
               Answer = "People can catch COVID-19 from others who have the virus. The disease can spread from person to person through small droplets from the nose or mouth which are spread when a person with COVID-19 coughs or exhales. These droplets land on objects and surfaces around the person. Other people then catch COVID-19 by touching these objects or surfaces, then touching their eyes, nose or mouth. People can also catch COVID-19 if they breathe in droplets from a person with COVID-19 who coughs out or exhales droplets. This is why it is important to stay more than 1 meter (3 feet) away from a person who is sick. WHO is assessing ongoing research on the ways COVID - 19 is spread and will continue to share updated findings."
           });




            QusetionList.Value.Add(

           new FAQModel()
           {
               Question = "What can I do to protect myself and prevent the spread of disease?",
               Answer = "Stay aware of the latest information on the COVID-19 outbreak, available on the WHO website and through your national and local public health authority. Many countries around the world have seen cases of COVID-19 and several have seen outbreaks. Authorities in China and some other countries have succeeded in slowing or stopping their outbreaks. However, the situation is unpredictable so check regularly for the latest news."
           });




            QusetionList.Value.Add(

           new FAQModel()
           {
               Question = "How likely am I to catch COVID-19?",
               Answer = "The risk depends on where you  are - and more specifically, whether there is a COVID-19 outbreak unfolding there.For most people in most locations the risk of catching COVID-19 is still low. However, there are now places around the world (cities or areas) where the disease is spreading. For people living in, or visiting, these areas the risk of catching COVID-19 is higher. Governments and health authorities are taking vigorous action every time a new case of COVID-19 is identified. Be sure to comply with any local restrictions on travel, movement or large gatherings. Cooperating with disease control efforts will reduce your risk of catching or spreading COVID-19.COVID-19 outbreaks can be contained and transmission stopped, as has been shown in China and some other countries. Unfortunately, new outbreaks can emerge rapidly. It’s important to be aware of the situation where you are or intend to go. WHO publishes daily updates on the COVID-19 situation worldwide."
           });



            QusetionList.Value.Add(

           new FAQModel()
           {
               Question = "Should I worry about COVID-19?",
               Answer = "Illness due to COVID-19 infection is generally mild, especially for children and young adults. However, it can cause serious illness: about 1 in every 5 people who catch it need hospital care. It is therefore quite normal for people to worry about how the COVID-19 outbreak will affect them and their loved ones.We can channel our concerns into actions to protect ourselves, our loved ones and our communities. First and foremost among these actions is regular and thorough hand-washing and good respiratory hygiene. Secondly, keep informed and follow the advice of the local health authorities including any restrictions put in place on travel, movement and gatherings."
           });




            QusetionList.Value.Add(

           new FAQModel()
           {
               Question = "Who is at risk of developing severe illness?",
               Answer = "While we are still learning about how COVID-2019 affects people, older persons and persons with pre-existing medical conditions (such as high blood pressure, heart disease, lung disease, cancer or diabetes)  appear to develop serious illness more often than others. "
           });



            QusetionList.Value.Add(

           new FAQModel()
           {
               Question = "Are antibiotics effective in preventing or treating the COVID-19?",
               Answer = "No. Antibiotics do not work against viruses, they only work on bacterial infections. COVID-19 is caused by a virus, so antibiotics do not work. Antibiotics should not be used as a means of prevention or treatment of COVID-19. They should only be used as directed by a physician to treat a bacterial infection. "
           });



            QusetionList.Value.Add(

           new FAQModel()
           {
               Question = "Are there any medicines or therapies that can prevent or cure COVID-19?",
               Answer = "While some western, traditional or home remedies may provide comfort and alleviate symptoms of COVID-19, there is no evidence that current medicine can prevent or cure the disease. WHO does not recommend self-medication with any medicines, including antibiotics, as a prevention or cure for COVID-19. However, there are several ongoing clinical trials that include both western and traditional medicines. WHO will continue to provide updated information as soon as clinical findings are available."
           });



            QusetionList.Value.Add(

           new FAQModel()
           {
               Question = "Is there a vaccine, drug or treatment for COVID-19?",
               Answer = "Not yet. To date, there is no vaccine and no specific antiviral medicine to prevent or treat COVID-2019. However, those affected should receive care to relieve symptoms. People with serious illness should be hospitalized. Most patients recover thanks to supportive care.Possible vaccines and some specific drug treatments are under investigation. They are being tested through clinical trials. WHO is coordinating efforts to develop vaccines and medicines to prevent and treat COVID-19.The most effective ways to protect yourself and others against COVID-19 are to frequently clean your hands, cover your cough with the bend of elbow or tissue, and maintain a distance of at least 1 meter (3 feet) from people who are coughing or sneezing."
           });

            QusetionList.Value.Add(

           new FAQModel()
           {
               Question = "Is COVID-19 the same as SARS?",
               Answer = "No. The virus that causes COVID-19 and the one that caused the outbreak of Severe Acute Respiratory Syndrome (SARS) in 2003 are related to each other genetically, but the diseases they cause are quite different.SARS was more deadly but much less infectious than COVID-19. There have been no outbreaks of SARS anywhere in the world since 2003."
           });

            QusetionList.Value.Add(

           new FAQModel()
           {
               Question = "Should I wear a mask to protect myself?",
               Answer = "Only wear a mask if you are ill with COVID-19 symptoms (especially coughing) or looking after someone who may have COVID-19. Disposable face mask can only be used once. If you are not ill or looking after someone who is ill then you are wasting a mask. There is a world-wide shortage of masks, so WHO urges people to use masks wisely.WHO advises rational use of medical masks to avoid unnecessary wastage of precious resources and mis-use of masks.The most effective ways to protect yourself and others against COVID-19 are to frequently clean your hands, cover your cough with the bend of elbow or tissue and maintain a distance of at least 1 meter (3 feet) from people who are coughing or sneezing"
           });

            QusetionList.Value.Add(

           new FAQModel()
           {
               Question = "How long is the incubation period for COVID-19?",
               Answer = "The “incubation period” means the time between catching the virus and beginning to have symptoms of the disease. Most estimates of the incubation period for COVID-19 range from 1-14 days, most commonly around five days. These estimates will be updated as more data become available."
           });

            QusetionList.Value.Add(

           new FAQModel()
           {
               Question = "Can humans become infected with the COVID-19 from an animal source?",
               Answer = "Coronaviruses are a large family of viruses that are common in animals. Occasionally, people get infected with these viruses which may then spread to other people. For example, SARS-CoV was associated with civet cats and MERS-CoV is transmitted by dromedary camels. Possible animal sources of COVID-19 have not yet been confirmed.  To protect yourself, such as when visiting live animal markets, avoid direct contact with animals and surfaces in contact with animals. Ensure good food safety practices at all times. Handle raw meat, milk or animal organs with care to avoid contamination of uncooked foods and avoid consuming raw or undercooked animal products."
           });

            QusetionList.Value.Add(

           new FAQModel()
           {
               Question = "Can I catch COVID-19 from my pet?",
               Answer = "1.We are aware of instances of animals and pets of COVID-19 patients being infected with the disease;  2.As the intergovernmental body responsible for improving animal health worldwide, the World Organisation for Animal Health (OIE) has been developing technical guidance on specialised topics related to animal health, dedicated to veterinary services and technical experts (including on testing and quarantine); 3.Based on current evidence, human to human transmission remains the main driver;  4.There is a possibility for some animals to become infected through close contact with infected humans.Further evidence is needed to understand if animals and pets can spread the disease; 4.It is still too early to say whether cats could be the intermediate host in the transmission of the COVID-19."
           });

            QusetionList.Value.Add(

           new FAQModel()
           {
               Question = "How long does the virus survive on surfaces?",
               Answer = "It is not certain how long the virus that causes COVID-19 survives on surfaces, but it seems to behave like other coronaviruses. Studies suggest that coronaviruses (including preliminary information on the COVID-19 virus) may persist on surfaces for a few hours or up to several days. This may vary under different conditions (e.g. type of surface, temperature or humidity of the environment).  If you think a surface may be infected, clean it with simple disinfectant to kill the virus and protect yourself and others. Clean your hands with an alcohol-based hand rub or wash them with soap and water. Avoid touching your eyes, mouth, or nose."
           });


            QusetionList.Value.Add(

           new FAQModel()
           {
               Question = "Is it safe to receive a package from any area where COVID-19 has been reported?",
               Answer = "Yes. The likelihood of an infected person contaminating commercial goods is low and the risk of catching the virus that causes COVID-19 from a package that has been moved, travelled, and exposed to different conditions and temperature is also low."
           });


            QusetionList.Value.Add(

           new FAQModel()
           {
               Question = "Is there anything I should not do?",
               Answer = "1.Smoking   2.Wearing multiple masks 3. Taking antibiotics(See question 10"
           });


            QusetionList.Value.Add(

           new FAQModel()
           {
               Question = "Is COVID-19 airborne?",
               Answer = "The virus that causes COVID-19 is mainly transmitted through droplets generated when an infected person coughs, sneezes, or speaks. These droplets are too heavy to hang in the air. They quickly fall on floors or surfaces.  You can be infected by breathing in the virus if you are within 1 metre of a person who has COVID-19, or by touching a contaminated surface and then touching your eyes, nose or mouth before washing your hands"
           });

            NotifyChage("QusetionList");
            //Task.Delay();
        }

    }
}
