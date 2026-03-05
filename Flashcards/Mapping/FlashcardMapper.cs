
namespace Flashcards.Mapping
{
    public static class FlashcardMapper
    {
        //TODO figure out why this isnt working
        public static DTO.FlashcardDTO ToDto(this Flashcard flaschard)
        {
            return new DTO.FlashcardDTO(
                flashcard.Question,
                flashcard.Answer);
        }
    }
}
