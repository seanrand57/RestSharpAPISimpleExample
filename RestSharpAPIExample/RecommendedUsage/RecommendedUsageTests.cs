using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RecommendedUsage
{
    [TestClass]
    public class RecommendedUsageTests
    {
        [TestMethod]
        public void PhotoTestID_WithID3()
        {
            JSONPlaceholder jph = new JSONPlaceholder("photos");
            Photo photo = jph.GetPhoto(3);

            Assert.AreEqual(photo.id, 3);
        }

        [TestMethod]
        public void PhotoTestAlbumID_WithID3()
        {
            JSONPlaceholder jph = new JSONPlaceholder("photos");
            Photo photo = jph.GetPhoto(3);

            Assert.AreEqual(photo.albumId, 1);
        }

        [TestMethod]
        public void PhotoTestTitle_WithID3()
        {
            JSONPlaceholder jph = new JSONPlaceholder("photos");
            Photo photo = jph.GetPhoto(3);

            Assert.AreEqual(photo.title, "officia porro iure quia iusto qui ipsa ut modi");
        }


        [TestMethod]
        public void PhotoTestURL_WithID3()
        {
            JSONPlaceholder jph = new JSONPlaceholder("photos");
            Photo photo = jph.GetPhoto(3);

            Assert.AreEqual(photo.url, "http://placehold.it/600/24f355");
        }

        [TestMethod]
        public void PhotoTestThumbnailURL_WithID3()
        {
            JSONPlaceholder jph = new JSONPlaceholder("photos");
            Photo photo = jph.GetPhoto(3);
            Assert.AreEqual(photo.thumbnailUrl, "http://placehold.it/150/1941e9");
        }
    }
}
