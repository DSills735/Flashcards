
namespace Flashcards.Mapping
{
    public static class FlashcardMapper
    {

        public static DTO.FlashcardDTO ToDto(this Flashcard flaschard)
        {
            return new DTO.FlashcardDTO(
                flashcard.Question,
                flashcard.Answer);
        }
    }
}
