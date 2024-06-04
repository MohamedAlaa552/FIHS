﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FIHS.Migrations
{
    /// <inheritdoc />
    public partial class seedPlants2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
            table: "Plants",
            columns: new[] { "Name", "ScientificName", "Description", "Color", "CommonUses", "NutritionalValue", "AverageYield", "SunlightReqs", "IrrigationReqs", "Temperature", "PlantingSeason", "HarvistingSeason", "CulivationTips", "ImageUrl" },
            values: new object[,]
                {
                    { "بابونج ألماني", "Matricaria recutita", "نبات عشبي مزهر يستخدم في العلاج بالأعشاب", "أصفر وأبيض", "العلاج بالأعشاب والشاي", "غني بمضادات الأكسدة", 0.3, "ضوء الشمس الكامل", "الري المعتدل", "15-25°C", "الربيع", "الصيف", "احصد الأزهار عندما تكون في أوجها", "\\images\\No_Image.jpg" },
                    { "حشيشة الليمون", "Cymbopogon flexuosus", "نبات عشبي يستخدم في الطهي والعلاج بالأعشاب", "أخضر", "الطهي والعلاج بالأعشاب", "غني بمضادات الأكسدة", 1.2, "ضوء الشمس الكامل", "الري المنتظم", "20-30°C", "الربيع", "الصيف", "قم بزراعة العشبة في تربة رطبة وجيدة التصريف", "\\images\\No_Image.jpg" },
                    { "نبتة العرن المثقوب", "Hypericum perforatum", "نبات مزهر يستخدم في العلاج بالأعشاب", "أصفر", "العلاج بالأعشاب", "غني بمضادات الأكسدة", 0.4, "ضوء الشمس الكامل", "الري المعتدل", "15-25°C", "الربيع", "الصيف", "احصد الأزهار والأوراق للاستخدام الطبي", "\\images\\No_Image.jpg" },
                    { "مرمية", "Salvia officinalis", "نبات عشبي يستخدم في الطهي والعلاج بالأعشاب", "أخضر", "الطهي والعلاج بالأعشاب", "غني بمضادات الأكسدة", 0.5, "ضوء الشمس الكامل", "الري المعتدل", "15-30°C", "الربيع", "الصيف", "قم بتقليم النبات بانتظام لتحفيز النمو الجديد", "\\images\\No_Image.jpg" },
                    { "حشيشة الملاك", "Angelica archangelica", "نبات عشبي يستخدم في العلاج بالأعشاب", "أخضر", "العلاج بالأعشاب", "غني بمضادات الأكسدة", 0.7, "ضوء الشمس الكامل", "الري المنتظم", "15-25°C", "الربيع", "الصيف", "احصد الجذور والسيقان للاستخدام الطبي", "\\images\\No_Image.jpg" },
                    { "قراص", "Urtica dioica", "نبات عشبي يستخدم في العلاج بالأعشاب والطهي", "أخضر", "العلاج بالأعشاب والطهي", "غني بالفيتامينات والمعادن", 1.0, "ضوء الشمس الجزئي", "الري المنتظم", "15-25°C", "الربيع", "الصيف", "احصد الأوراق بحذر بسبب الأشواك", "\\images\\No_Image.jpg" },
                    { "شمر", "Foeniculum vulgare", "نبات عشبي يستخدم في الطهي والتوابل", "أخضر", "الطهي والتوابل", "غني بالألياف والفيتامينات", 0.9, "ضوء الشمس الكامل", "الري المعتدل", "15-30°C", "الربيع", "الصيف", "احصد البذور والأوراق للاستخدام", "\\images\\No_Image.jpg" },
                    { "نبات الأذريون", "Calendula officinalis", "نبات مزهر يستخدم في العلاج بالأعشاب", "برتقالي", "العلاج بالأعشاب والزينة", "غني بمضادات الأكسدة", 0.3, "ضوء الشمس الكامل", "الري المعتدل", "15-25°C", "الربيع", "الصيف", "احصد الأزهار عندما تكون في أوجها", "\\images\\No_Image.jpg" },
                    { "زوفا", "Hyssopus officinalis", "نبات عشبي يستخدم في الطهي والعلاج بالأعشاب", "أزرق", "الطهي والعلاج بالأعشاب", "غني بالفيتامينات والمعادن", 0.4, "ضوء الشمس الكامل", "الري المعتدل", "20-30°C", "الربيع", "الصيف", "قم بزراعة الزوفا في تربة جيدة التصريف", "\\images\\No_Image.jpg" },
                    { "عرعر", "Juniperus communis", "نبات عشبي يستخدم في الطهي والعلاج بالأعشاب", "أخضر", "الطهي والعلاج بالأعشاب", "غني بمضادات الأكسدة", 0.8, "ضوء الشمس الكامل", "الري المعتدل", "15-30°C", "الربيع", "الصيف", "احصد التوت والأوراق للاستخدام", "\\images\\No_Image.jpg" },
                { "زيتون", "Olea europaea", "شجرة مثمرة تنتج الزيتون", "أخضر", "إنتاج الزيتون والزيت", "غني بفيتامين E والأحماض الدهنية الأحادية غير المشبعة", 100, "ضوء الشمس الكامل", "الري المعتدل", "15-30°C", "الربيع", "الخريف", "قم بتقليم الأشجار بانتظام لتحفيز النمو والإنتاج", "\\images\\No_Image.jpg" },
                    { "نخيل التمر", "Phoenix dactylifera", "شجرة نخيل تنتج التمر", "بني", "إنتاج التمر", "غني بالفيتامينات والمعادن والألياف", 150, "ضوء الشمس الكامل", "الري المنتظم", "20-35°C", "الربيع", "الصيف", "احرص على الري الجيد في مراحل النمو المبكرة", "\\images\\No_Image.jpg" },
                    { "رمان", "Punica granatum", "شجرة مثمرة تنتج الرمان", "أحمر", "استهلاك الفاكهة وإنتاج العصير", "غني بمضادات الأكسدة وفيتامين C", 50, "ضوء الشمس الكامل", "الري المعتدل", "15-30°C", "الربيع", "الخريف", "قم بتقليم الأشجار لتحفيز الإنتاج الجيد", "\\images\\No_Image.jpg" },
                    { "تين", "Ficus carica", "شجرة مثمرة تنتج التين", "أخضر", "استهلاك الفاكهة المجففة والطازجة", "غني بالألياف والفيتامينات", 80, "ضوء الشمس الكامل", "الري المعتدل", "15-30°C", "الربيع", "الصيف", "احرص على الري المنتظم خلال فترة النمو", "\\images\\No_Image.jpg" },
                    { "تفاح", "Malus domestica", "شجرة مثمرة تنتج التفاح", "أحمر وأخضر", "استهلاك الفاكهة وإنتاج العصير", "غني بالفيتامينات والألياف", 70, "ضوء الشمس الكامل", "الري المعتدل", "15-25°C", "الربيع", "الخريف", "قم بتقليم الأشجار لتحفيز النمو والإنتاج", "\\images\\No_Image.jpg" },
                    { "برتقال", "Citrus sinensis", "شجرة مثمرة تنتج البرتقال", "برتقالي", "استهلاك الفاكهة وإنتاج العصير", "غني بفيتامين C", 60, "ضوء الشمس الكامل", "الري المنتظم", "15-30°C", "الربيع", "الخريف", "احرص على الري الجيد خاصة خلال فترة النمو", "\\images\\No_Image.jpg" },
                    { "ليمون", "Citrus limon", "شجرة مثمرة تنتج الليمون", "أصفر", "استهلاك الفاكهة وإنتاج العصير", "غني بفيتامين C", 50, "ضوء الشمس الكامل", "الري المنتظم", "15-30°C", "الربيع", "الخريف", "قم بتقليم الأشجار بانتظام لتحفيز النمو والإنتاج", "\\images\\No_Image.jpg" },
                    { "مانجو", "Mangifera indica", "شجرة مثمرة تنتج المانجو", "أصفر وبرتقالي", "استهلاك الفاكهة وإنتاج العصير", "غني بالفيتامينات والمعادن", 100, "ضوء الشمس الكامل", "الري المنتظم", "25-35°C", "الربيع", "الصيف", "قم بتقليم الأشجار بانتظام لتحفيز النمو والإنتاج", "\\images\\No_Image.jpg" },
                    { "أفوكادو", "Persea americana", "شجرة مثمرة تنتج الأفوكادو", "أخضر", "استهلاك الفاكهة وإنتاج الزيت", "غني بالدهون الصحية وفيتامينات E و K", 40, "ضوء الشمس الكامل", "الري المنتظم", "15-25°C", "الربيع", "الخريف", "احرص على الري الجيد خاصة خلال فترة النمو", "\\images\\No_Image.jpg" },
                    { "كيوي", "Actinidia deliciosa", "شجرة مثمرة تنتج الكيوي", "بني وأخضر", "استهلاك الفاكهة", "غني بفيتامين C والألياف", 70, "ضوء الشمس الكامل", "الري المنتظم", "10-25°C", "الربيع", "الخريف", "قم بزراعة الكيوي في تربة جيدة التصريف", "\\images\\No_Image.jpg" },
                { "رودودندرون", "Rhododendron", "شجيرة دائمة الخضرة مزهرة", "أرجواني", "زينة", "غير متوفر", 0, "ضوء الشمس الجزئي", "الري المنتظم", "10-25°C", "الربيع", "الربيع", "قم بزراعة الرودودندرون في تربة حمضية وجيدة التصريف", "\\images\\No_Image.jpg" },
                    { "الغار", "Laurus nobilis", "شجيرة دائمة الخضرة تستخدم أوراقها في الطهي", "أخضر", "الطهي والزينة", "غير متوفر", 0, "ضوء الشمس الجزئي إلى الكامل", "الري المعتدل", "10-30°C", "الربيع", "الخريف", "قم بتقليم النبات بانتظام للحفاظ على شكله", "\\images\\No_Image.jpg" },
                    { "الياسمين", "Jasminum", "شجيرة دائمة الخضرة مزهرة", "أبيض", "زينة وصناعة العطور", "غير متوفر", 0, "ضوء الشمس الكامل", "الري المعتدل", "15-30°C", "الربيع", "الصيف", "قم بزراعة الياسمين في تربة جيدة التصريف", "\\images\\No_Image.jpg" },
                    { "أزاليا", "Azalea", "شجيرة دائمة الخضرة مزهرة", "وردي", "زينة", "غير متوفر", 0, "ضوء الشمس الجزئي", "الري المنتظم", "10-25°C", "الربيع", "الربيع", "قم بزراعة الأزالية في تربة حمضية وجيدة التصريف", "\\images\\No_Image.jpg" },
                    { "الدفلى", "Nerium oleander", "شجيرة دائمة الخضرة مزهرة", "أبيض ووردي", "زينة", "غير متوفر", 0, "ضوء الشمس الكامل", "الري المعتدل", "15-30°C", "الربيع", "الصيف", "احرص على تجنب تناول أوراق الدفلى لأنها سامة", "\\images\\No_Image.jpg" },
                    { "الكاميليا", "Camellia", "شجيرة دائمة الخضرة مزهرة", "أبيض وأحمر", "زينة", "غير متوفر", 0, "ضوء الشمس الجزئي", "الري المنتظم", "10-25°C", "الربيع", "الربيع", "قم بزراعة الكاميليا في تربة حمضية وجيدة التصريف", "\\images\\No_Image.jpg" },
                    { "الغاردينيا", "Gardenia", "شجيرة دائمة الخضرة مزهرة", "أبيض", "زينة وصناعة العطور", "غير متوفر", 0, "ضوء الشمس الجزئي", "الري المنتظم", "15-25°C", "الربيع", "الصيف", "قم بزراعة الغاردينيا في تربة حمضية وجيدة التصريف", "\\images\\No_Image.jpg" },
                    { "البوكسوود", "Buxus sempervirens", "شجيرة دائمة الخضرة", "أخضر", "زينة", "غير متوفر", 0, "ضوء الشمس الجزئي إلى الكامل", "الري المعتدل", "10-30°C", "الربيع", "الخريف", "قم بتقليم البوكسوود للحفاظ على شكله", "\\images\\No_Image.jpg" },
                    { "بيريس", "Pieris japonica", "شجيرة دائمة الخضرة مزهرة", "أبيض", "زينة", "غير متوفر", 0, "ضوء الشمس الجزئي", "الري المنتظم", "10-25°C", "الربيع", "الربيع", "قم بزراعة البيريس في تربة حمضية وجيدة التصريف", "\\images\\No_Image.jpg" },
                    { "الروزماري", "Rosmarinus officinalis", "شجيرة دائمة الخضرة تستخدم في الطهي", "أخضر", "الطهي والزينة", "غني بمضادات الأكسدة", 0, "ضوء الشمس الكامل", "الري المعتدل", "15-30°C", "الربيع", "الصيف", "قم بتقليم النبات بانتظام لتحفيز النمو الجديد", "\\images\\No_Image.jpg" },
                { "ألوة فيرا", "Aloe vera", "نبات عصاري يستخدم في العلاج بالأعشاب", "أخضر", "العلاج بالأعشاب والعناية بالبشرة", "غني بمضادات الأكسدة والفيتامينات", 0, "ضوء الشمس الجزئي إلى الكامل", "الري القليل", "20-30°C", "الربيع", "الصيف", "قم بزراعة الألوة فيرا في تربة جيدة التصريف واترك التربة تجف بين الريات", "\\images\\No_Image.jpg" },
                    { "صبار الإجاص الشائك", "Opuntia", "نبات عصاري يستخدم في الطهي والعلاج بالأعشاب", "أخضر", "الطهي والعلاج بالأعشاب", "غني بالألياف والفيتامينات", 0, "ضوء الشمس الكامل", "الري القليل", "20-35°C", "الربيع", "الصيف", "احرص على الري القليل واترك التربة تجف بين الريات", "\\images\\No_Image.jpg" },
                    { "سنسفيرا", "Sansevieria", "نبات عصاري يستخدم في الزينة", "أخضر", "الزينة", "غير متوفر", 0, "ضوء الشمس الجزئي إلى الكامل", "الري القليل", "15-30°C", "الربيع", "الصيف", "قم بزراعة السنسفيرا في تربة جيدة التصريف واترك التربة تجف بين الريات", "\\images\\No_Image.jpg" },
                    { "أغاف", "Agave", "نبات عصاري يستخدم في الطهي وصناعة الشراب", "أخضر", "الطهي وصناعة الشراب", "غني بالسكريات", 0, "ضوء الشمس الكامل", "الري القليل", "20-35°C", "الربيع", "الصيف", "احرص على الري القليل واترك التربة تجف بين الريات", "\\images\\No_Image.jpg" },
                    { "صبار الهوديا", "Hoodia", "نبات عصاري يستخدم في العلاج بالأعشاب", "أخضر", "العلاج بالأعشاب", "غني بمضادات الأكسدة", 0, "ضوء الشمس الكامل", "الري القليل", "20-35°C", "الربيع", "الصيف", "احرص على الري القليل واترك التربة تجف بين الريات", "\\images\\No_Image.jpg" },
                    { "صبار زيبرينا", "Zebra cactus", "نبات عصاري يستخدم في الزينة", "أخضر", "الزينة", "غير متوفر", 0, "ضوء الشمس الجزئي إلى الكامل", "الري القليل", "15-30°C", "الربيع", "الصيف", "قم بزراعة صبار زيبرينا في تربة جيدة التصريف واترك التربة تجف بين الريات", "\\images\\No_Image.jpg" },
                    { "صبار البارليريا", "Parlour Palm", "نبات عصاري يستخدم في الزينة", "أخضر", "الزينة", "غير متوفر", 0, "ضوء الشمس الجزئي", "الري القليل", "15-25°C", "الربيع", "الصيف", "قم بزراعة صبار البارليريا في تربة جيدة التصريف واترك التربة تجف بين الريات", "\\images\\No_Image.jpg" },
                    { "صبار القنفذ", "Echinopsis", "نبات عصاري مزهر", "أخضر", "الزينة", "غير متوفر", 0, "ضوء الشمس الكامل", "الري القليل", "20-35°C", "الربيع", "الصيف", "قم بزراعة صبار القنفذ في تربة جيدة التصريف واترك التربة تجف بين الريات", "\\images\\No_Image.jpg" },
                    { "ألوة عريضة الأوراق", "Aloe arborescens", "نبات عصاري يستخدم في العلاج بالأعشاب", "أخضر", "العلاج بالأعشاب", "غني بمضادات الأكسدة", 0, "ضوء الشمس الجزئي إلى الكامل", "الري القليل", "20-30°C", "الربيع", "الصيف", "قم بزراعة الألوة في تربة جيدة التصريف واترك التربة تجف بين الريات", "\\images\\No_Image.jpg" },
                    { "صبار كريسولا", "Crassula", "نبات عصاري يستخدم في الزينة", "أخضر", "الزينة", "غير متوفر", 0, "ضوء الشمس الجزئي إلى الكامل", "الري القليل", "15-30°C", "الربيع", "الصيف", "قم بزراعة صبار كريسولا في تربة جيدة التصريف واترك التربة تجف بين الريات", "\\images\\No_Image.jpg" },
                { "زهرة العسل", "Lonicera", "نبات متسلق مزهر برائحة عطرة", "أصفر وأبيض", "زينة وتغطية الجدران والأسوار", "غير متوفر", 0, "ضوء الشمس الكامل إلى الجزئي", "الري المعتدل", "10-30°C", "الربيع", "الصيف", "قم بزراعة زهرة العسل في تربة جيدة التصريف وقم بتوجيهها نحو الدعم", "\\images\\No_Image.jpg" },
                    { "ياسمين", "Jasminum", "نبات متسلق مزهر برائحة عطرة", "أبيض", "زينة وصناعة العطور", "غير متوفر", 0, "ضوء الشمس الكامل", "الري المنتظم", "15-30°C", "الربيع", "الصيف", "قم بزراعة الياسمين في تربة جيدة التصريف وقم بتوجيهه نحو الدعم", "\\images\\No_Image.jpg" },
                    { "لبلاب إنجليزي", "Hedera helix", "نبات متسلق يستخدم لتغطية الجدران والأسوار", "أخضر", "زينة وتغطية الجدران والأسوار", "غير متوفر", 0, "ضوء الشمس الجزئي إلى الكامل", "الري المنتظم", "10-25°C", "الربيع", "الخريف", "قم بزراعة اللبلاب في تربة جيدة التصريف وقم بتوجيهه نحو الدعم", "\\images\\No_Image.jpg" },
                    { "بوجنفيليا", "Bougainvillea", "نبات متسلق مزهر بألوان زاهية", "وردي وبرتقالي", "زينة", "غير متوفر", 0, "ضوء الشمس الكامل", "الري المعتدل", "20-35°C", "الربيع", "الصيف", "قم بزراعة البوجنفيليا في تربة جيدة التصريف وقم بتوجيهها نحو الدعم", "\\images\\No_Image.jpg" },
                    { "وردة المتسلق", "Rosa", "نبات متسلق مزهر بأزهار عطرية", "أحمر وأبيض", "زينة", "غير متوفر", 0, "ضوء الشمس الكامل", "الري المعتدل", "15-30°C", "الربيع", "الصيف", "قم بزراعة وردة المتسلق في تربة جيدة التصريف وقم بتوجيهها نحو الدعم", "\\images\\No_Image.jpg" },
                    { "زهرة الساعة", "Passiflora", "نبات متسلق مزهر بأزهار فريدة", "أرجواني", "زينة", "غير متوفر", 0, "ضوء الشمس الكامل", "الري المنتظم", "15-30°C", "الربيع", "الصيف", "قم بزراعة زهرة الساعة في تربة جيدة التصريف وقم بتوجيهها نحو الدعم", "\\images\\No_Image.jpg" },
                    { "كرمة الفلامنجو", "Antigonon leptopus", "نبات متسلق مزهر بأزهار وردية", "وردي", "زينة", "غير متوفر", 0, "ضوء الشمس الكامل", "الري المعتدل", "20-35°C", "الربيع", "الصيف", "قم بزراعة كرمة الفلامنجو في تربة جيدة التصريف وقم بتوجيهها نحو الدعم", "\\images\\No_Image.jpg" },
                    { "كرمة العشق", "Campsis radicans", "نبات متسلق مزهر بأزهار برتقالية", "برتقالي", "زينة", "غير متوفر", 0, "ضوء الشمس الكامل", "الري المنتظم", "15-30°C", "الربيع", "الصيف", "قم بزراعة كرمة العشق في تربة جيدة التصريف وقم بتوجيهها نحو الدعم", "\\images\\No_Image.jpg" },
                    { "زهرة الصباح", "Ipomoea", "نبات متسلق مزهر بأزهار ملونة", "أزرق وأرجواني", "زينة", "غير متوفر", 0, "ضوء الشمس الكامل", "الري المنتظم", "20-35°C", "الربيع", "الصيف", "قم بزراعة زهرة الصباح في تربة جيدة التصريف وقم بتوجيهها نحو الدعم", "\\images\\No_Image.jpg" },
                    { "متسلق الجهنمية", "Clerodendrum thomsoniae", "نبات متسلق مزهر بأزهار حمراء", "أحمر وأبيض", "زينة", "غير متوفر", 0, "ضوء الشمس الجزئي إلى الكامل", "الري المنتظم", "20-30°C", "الربيع", "الصيف", "قم بزراعة متسلق الجهنمية في تربة جيدة التصريف وقم بتوجيهها نحو الدعم", "\\images\\No_Image.jpg" },
                { "سرو", "Cupressus", "نوع من الأشجار المخروطية ذات الأوراق الخضراء الدائمة", "أخضر", "زينة، حواجز الرياح، أخشاب", "غير متوفر", 0, "ضوء الشمس الكامل", "الري المتوسط", "15-25°C", "الربيع", "الخريف", "يفضل تربة جيدة التصريف والتسميد المنتظم", "\\images\\No_Image.jpg" },
                    { "سرو كريت", "Cupressus sempervirens", "نوع من الأشجار المخروطية ذات الأوراق الخضراء الدائمة", "أخضر", "زينة، حواجز الرياح، أخشاب", "غير متوفر", 0, "ضوء الشمس الكامل", "الري المتوسط", "15-25°C", "الربيع", "الخريف", "يفضل تربة جيدة التصريف والتسميد المنتظم", "\\images\\No_Image.jpg" },
                    { "سرو لاوير", "Cupressus lusitanica", "نوع من الأشجار المخروطية ذات الأوراق الخضراء الدائمة", "أخضر", "زينة، حواجز الرياح، أخشاب", "غير متوفر", 0, "ضوء الشمس الكامل", "الري المتوسط", "15-25°C", "الربيع", "الخريف", "يفضل تربة جيدة التصريف والتسميد المنتظم", "\\images\\No_Image.jpg" },
                    { "شجرة الصنوبر", "Pinus", "أشجار مخروطية ذات أوراق إبرية", "أخضر", "زينة، أخشاب، صناعة الورق", "غير متوفر", 0, "ضوء الشمس الكامل", "الري المتوسط", "15-25°C", "الربيع", "الخريف", "يفضل تربة جيدة التصريف والتسميد المنتظم", "\\images\\No_Image.jpg" },
                    { "شجرة الصنوبر الأبيض", "Pinus strobus", "أشجار مخروطية ذات أوراق إبرية", "أخضر", "زينة، أخشاب، صناعة الورق", "غير متوفر", 0, "ضوء الشمس الكامل", "الري المتوسط", "15-25°C", "الربيع", "الخريف", "يفضل تربة جيدة التصريف والتسميد المنتظم", "\\images\\No_Image.jpg" },
                    { "سرو كاليفورنيا", "Cupressus macrocarpa", "نوع من الأشجار المخروطية ذات الأوراق الخضراء الدائمة", "أخضر", "زينة، حواجز الرياح، أخشاب", "غير متوفر", 0, "ضوء الشمس الكامل", "الري المتوسط", "15-25°C", "الربيع", "الخريف", "يفضل تربة جيدة التصريف والتسميد المنتظم", "\\images\\No_Image.jpg" },
                    { "سرو بالوتيا", "Cupressus sempervirens 'Pyramidalis'", "نوع من الأشجار المخروطية ذات الأوراق الخضراء الدائمة", "أخضر", "زينة، حواجز الرياح، أخشاب", "غير متوفر", 0, "ضوء الشمس الكامل", "الري المتوسط", "15-25°C", "الربيع", "الخريف","يفضل تربة جيدة التصريف والتسميد المنتظم", "\\images\\No_Image.jpg" },
                    { "سرو كريبتومرا", "Cupressus cashmeriana", "أشجار مخروطية ذات أوراق خضراء داكنة ومزهرة بأزهار وردية", "أخضر", "زينة، حواجز الرياح، أخشاب", "غير متوفر", 0, "ضوء الشمس الكامل", "الري المتوسط", "15-25°C", "الربيع", "الخريف", "يفضل تربة جيدة التصريف والتسميد المنتظم", "\\images\\No_Image.jpg" },
                    { "أرز لبناني", "Cedrus libani", "أشجار مخروطية ذات أوراق إبرية مزهرة بأزهار عنابية", "أخضر", "زينة، أخشاب", "غير متوفر", 0, "ضوء الشمس الكامل", "الري المتوسط", "15-25°C", "الربيع", "الخريف", "يفضل تربة جيدة التصريف والتسميد المنتظم", "\\images\\No_Image.jpg" },
                    { "صنوبر بحري", "Pinus pinaster", "أشجار مخروطية ذات أوراق إبرية تستخدم لاستخراج الصمغ", "أخضر", "زينة، أخشاب، صمغ", "غير متوفر", 0, "ضوء الشمس الكامل", "الري المتوسط", "15-25°C", "الربيع", "الخريف", "يفضل تربة جيدة التصريف والتسميد المنتظم", "\\images\\No_Image.jpg" },
                { "البلبل المائي", "Nymphoides indica", "نبات مائي ينتمي إلى عائلة السماقيات", "أخضر", "تنقية المياه، زينة الأحواض المائية", "غير متوفر", 0, "ضوء الشمس الكامل إلى الجزئي", "الري المتوسط", "20-28°C", "الربيع", "الصيف", "يفضل زراعته في تربة خصبة وغنية بالمواد العضوية", "\\images\\No_Image.jpg" },
                    { "السوسنة المائية", "Nymphaea", "نبات مائي يتميز بزهور كبيرة وجذور تنمو في قاع المياه", "متنوعة", "زينة البرك المائية، تنقية المياه", "غير متوفر", 0, "ضوء الشمس الكامل", "الري المتوسط", "20-30°C", "الربيع", "الصيف", "تتطلب تربة غنية بالمواد العضوية وعمق الماء مناسب لنمو الجذور", "\\images\\No_Image.jpg" },
                    { "البامية المائية", "Ludwigia", "نبات مائي يتميز بأوراقه الخضراء الغنية بالفيتامينات والمعادن", "أخضر", "تنقية المياه، زينة البرك المائية", "غير متوفر", 0, "ضوء الشمس الكامل إلى الجزئي", "الري المتوسط", "22-28°C", "الربيع", "الصيف", "ينمو في التربة الطينية الغنية بالعناصر الغذائية", "\\images\\No_Image.jpg" },
                    { "القرنفل المائي", "Nuphar lutea", "نبات مائي ينتمي إلى عائلة القرنفليات", "أخضر", "زينة البرك المائية، تنقية المياه", "غير متوفر", 0, "ضوء الشمس الجزئي إلى الكامل", "الري المتوسط", "20-30°C", "الربيع", "الصيف", "يتطلب تربة طينية القوام ويفضل التواجد في مياه هادئة", "\\images\\No_Image.jpg" },
                    { "الأزولا المائية", "Azolla", "نبات مائي صغير الحجم ينمو على سطح الماء", "أخضر", "تغطية سطح المياه، تحسين جودة الماء", "غير متوفر", 0, "ضوء الشمس الكامل إلى الجزئي", "الري المتوسط", "18-25°C", "الربيع", "الصيف", "يتطلب مياه نقية وغنية بالعناصر الغذائية", "\\images\\No_Image.jpg" },
                    { "الأزولا المائية الحمراء", "Azolla filiculoides", "نبات مائي صغير الحجم ينمو على سطح الماء ويتميز بلون أحمر", "أحمر", "تغطية سطح المياه، تحسين جودة الماء", "غير متوفر", 0, "ضوء الشمس الكامل إلى الجزئي", "الري المتوسط", "18-25°C", "الربيع", "الصيف", "يتطلب مياه نقية وغنية بالعناصر الغذائية", "\\images\\No_Image.jpg" },
                    { "الباربيندو", "Ceratophyllum", "نبات مائي يتميز بأوراقه الريشية وتكاثره السريع", "أخضر", "تنقية المياه، زينة البرك المائية", "غير متوفر", 0, "ضوء الشمس الكامل إلى الجزئي", "الري المتوسط", "18-25°C", "الربيع", "الصيف", "يتطلب تغيير مياه البرك المائية بانتظام لتجنب تراكم الطحالب", "\\images\\No_Image.jpg" },
                    { "الهوتيا", "Hydrilla verticillata", "نبات مائي سريع النمو يستخدم في تحسين جودة المياه", "أخضر", "تنقية المياه، تغطية سطح المياه","غير متوفر",0,"ضوء الشمس الكامل إلى الجزئي","الري المتوسط","18-25°C","الربيع","الصيف","يمكن زراعته في أحواض مائية صغيرة أو برك مائية، ويتطلب توفير التهوية والتغذية اللازمة","\\images\\No_Image.jpg" },
                    { "البينيا", "Pistia", "نبات مائي يشبه الشوك في شكله وينمو على سطح الماء", "أخضر","تنقية المياه، زينة البرك المائية","غير متوفر",0,"ضوء الشمس الكامل","الري المتوسط","18-30°C","الربيع","الصيف","يتطلب مياه نظيفة وغنية بالعناصر الغذائية للنمو الجيد","\\images\\No_Image.jpg" },
                    { "المستنقعات", "Limnobium laevigatum", "نبات مائي صغير ينمو في المستنقعات والبرك الضحلة", "أخضر","تنقية المياه، زينة البرك المائية","غير متوفر",0,"ضوء الشمس الكامل إلى الجزئي","الري المتوسط","20-28°C","الربيع","الصيف","يمكن زراعته في المستنقعات الصغيرة أو برك المياه الضحلة","\\images\\No_Image.jpg" },
                    { "الفاوانيا المائية", "Cabomba", "نبات مائي يتميز بأوراقه الخضراء الناعمة والزهور البيضاء أو الوردية", "أخضر","زينة البرك المائية، تنقية المياه","غير متوفر",0,"ضوء الشمس الكامل إلى الجزئي","الري المتوسط","22-28°C","الربيع","الصيف","يحتاج إلى مياه نظيفة وغنية بالعناصر الغذائية للنمو الجيد","\\images\\No_Image.jpg" },
                { "الكركديه البري", "Hibiscus syriacus", "نبات بري مزهر يتميز بأزهاره الجميلة والملونة", "متنوع", "زينة، استخدامات طبية", "غير متوفر", 0, "ضوء الشمس الكامل", "الري المتوسط", "20-30°C", "الربيع", "الصيف", "ينمو في تربة جيدة التصريف ويفضل تقليم الأفرع الميتة", "\\images\\No_Image.jpg" },
                    { "الخس البري", "Lactuca serriola", "نبات بري يتميز بأوراقه الخضراء اللامعة والمفترسة", "أخضر", "تغذية حيوانات معينة", "غير متوفر", 0, "ضوء الشمس الكامل إلى الجزئي", "الري المتوسط", "15-25°C", "الخريف", "الصيف", "يفضل زراعته في التربة الغنية بالمواد العضوية", "\\images\\No_Image.jpg" },
                    { "العرعر البري", "Rhamnus alaternus", "نبات بري يتميز بأوراقه الصغيرة والزهور الرائعة", "أخضر", "زينة، استخدامات طبية", "غير متوفر", 0, "ضوء الشمس الكامل إلى الجزئي", "الري المتوسط", "20-30°C", "الربيع", "الصيف", "ينمو في التربة الجيدة التصريف والحموضة المتوسطة", "\\images\\No_Image.jpg" },
                    { "الزعرور البري", "Crataegus monogyna", "نبات بري يتميز بأزهاره البيضاء والثمار الحمراء", "متنوع", "زينة، استخدامات طبية", "غير متوفر", 0, "ضوء الشمس الكامل", "الري المتوسط", "20-30°C", "الربيع", "الصيف", "يفضل زراعته في التربة الرطبة والغنية بالمواد العضوية", "\\images\\No_Image.jpg" },
                    { "الشمام البري", "Cucumis melo", "نبات بري ينتج ثمارًا ذات نكهة لذيذة وعطرة", "أخضر", "تغذية حيوانات معينة", "غير متوفر", 0, "ضوء الشمس الكامل إلى الجزئي", "الري المتوسط", "20-30°C", "الربيع", "الصيف", "يحتاج إلى تربة جيدة التهوية والرطوبة المتوسطة", "\\images\\No_Image.jpg" },
                    { "السعد البري", "Hypericum perforatum", "نبات بري معروف بخصائصه الطبية", "أخضر", "استخدامات طبية", "غير متوفر", 0, "ضوء الشمس الكامل", "الري المتوسط", "20-25°C", "الربيع", "الصيف", "ينمو في التربة الجافة والقلوية", "\\images\\No_Image.jpg" },
                    { "البابونج البري", "Matricaria chamomilla", "نبات بري معروف بفوائده الطبية والتهدئة", "أخضر", "استخدامات طبية", "غير متوفر", 0, "ضوء الشمس الكامل", "الري المتوسط", "15-30°C", "الربيع", "الصيف", "ينمو في التربة الجافة والجيدة التصريف", "\\images\\No_Image.jpg" },
                    { "الأقحوان البري", "Bellis perennis", "نبات بري يتميز بزهوره الصغيرة ذات اللون الأبيض والوردي", "متنوع", "زينة، استخدامات طبية", "غير متوفر", 0, "ضوء الشمس الكامل إلى الجزئي", "الري المتوسط", "10-20°C", "الربيع", "الصيف", "ينمو في التربة الجيدة التصريف ويحتاج إلى التسميد المنتظم", "\\images\\No_Image.jpg" },
                    { "القرنفل البري", "Dianthus deltoides", "نبات بري معمر يتميز بزهوره الجذابة والملونة", "متنوع", "زينة", "غير متوفر", 0, "ضوء الشمس الكامل", "الري المتوسط", "15-25°C", "الربيع", "الصيف", "يحتاج إلى تربة جيدة التصريف والتسميد المنتظم", "\\images\\No_Image.jpg" },
                { "اللوز", "Prunus dulcis", "شجرة معمرة تنتج ثمارًا لذيذة تحتوي على الفيتامينات والمعادن", "أخضر", "تناول الثمار واستخدامات طبية", "غني بالبروتينات والدهون الصحية", 8, "ضوء الشمس الكامل", "الري المتوسط", "15-25°C", "الشتاء", "الربيع", "يفضل التربة الجيدة التصريف والتسميد العضوي", "\\images\\No_Image.jpg" },
                    { "الزنجبيل", "Zingiber officinale", "نبات عشبي معمر يستخدم كتوابل وله فوائد صحية عديدة", "أخضر", "تحضير الطعام واستخدامات طبية", "غني بالمواد الكيميائية الحيوية", 0.5, "ضوء الشمس الجزئي إلى الكامل", "الري المتوسط", "20-30°C", "الربيع", "الخريف", "يتطلب تربة جيدة التصريف والتسميد العضوي", "\\images\\No_Image.jpg" },
                    { "العنب", "Vitis vinifera", "نبات معمر ينتج عناقيد العنب المشهورة بنكهتها الرائعة", "متنوع", "تناول الثمار وإنتاج العصير والنبيذ", "غني بالفيتامينات والمعادن", 15, "ضوء الشمس الكامل", "الري المتوسط", "20-30°C", "الربيع", "الصيف", "يحتاج إلى دعم للزراعة العمودية والتسميد المنتظم", "\\images\\No_Image.jpg" },
                    { "الكرفس", "Apium graveolens", "نبات عشبي معمر يستخدم في الطهي وله فوائد صحية عديدة", "أخضر", "تحضير الطعام واستخدامات طبية", "غني بالفيتامينات والمعادن", 0.5, "ضوء الشمس الجزئي إلى الكامل", "الري المتوسط", "15-20°C", "الخريف", "الربيع", "يتطلب تربة غنية بالمواد العضوية والرطوبة المتوسطة", "\\images\\No_Image.jpg" },
                { "الصبار", "Opuntia", "نبات صحراوي معمر يتحمل الظروف الجافة والحارة", "متنوع", "تناول الثمار وزينة", "غني بالألياف والفيتامينات", 5, "ضوء الشمس الكامل", "الري المتوسط", "20-40°C", "الربيع", "الصيف", "ينمو في التربة الجيدة التصريف ويحتاج إلى الري الخفيف", "\\images\\No_Image.jpg" },
                    { "العين الجملية", "Agave americana", "نبات صحراوي ذو أوراق سميكة وطويلة يُستخدم في الصناعات المحلية", "أخضر", "زينة", "غير متوفر", 0, "ضوء الشمس الكامل", "الري المتوسط", "25-40°C", "الربيع", "الصيف", "ينمو في التربة الجيدة التصريف ويحتاج إلى الري المتوسط", "\\images\\No_Image.jpg" },
                    { "الأغاف", "Acacia tortilis", "شجرة صحراوية تتحمل الجفاف وتستخدم في البناء وإنتاج الأخشاب", "متنوع", "بناء المواد وإنتاج الأخشاب", "غني بالألياف والبروتينات", 2, "ضوء الشمس الكامل", "الري المتوسط", "20-40°C", "الخريف", "الشتاء", "يتطلب التسميد المنتظم والمحافظة على التربة الرطبة", "\\images\\No_Image.jpg" },
                    { "البتولا الصحراوية", "Tamarix aphylla", "شجيرة صحراوية تتحمل الجفاف وتنمو في التربة القاحلة", "أخضر", "تحسين التربة وحمايتها من التآكل", "غير متوفر", 0, "ضوء الشمس الكامل", "الري المتوسط", "25-45°C", "الربيع", "الصيف", "يمكن زراعتها في التربة الجافة والقلوية", "\\images\\No_Image.jpg" },
                    { "السمار الصحراوي", "Artemisia herba-alba", "نبات صحراوي معمر يستخدم في الطب الشعبي وصناعة العطور", "أخضر", "استخدامات طبية وصناعية", "غني بالزيوت العطرية والمركبات الطبية", 0, "ضوء الشمس الكامل", "الري المتوسط", "20-35°C", "الخريف", "الربيع", "يفضل التربة الجيدة التصريف والتسميد المنتظم", "\\images\\No_Image.jpg" }

        }
            );

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [Plants]");
        }
    }
}
