const mongoose = require("mongoose");
const slugify = require("slugify");
const geocoder = require("../utils/geocoder");

const GemployeSchema = new mongoose.Schema(
  {
    name: {
      type: String,
      required: [true, "Please add a name"],
      unique: true,
      trim: true,
      maxlength: [50, "Name can not be more than 50 characters"],
    },
    slug: String,
    // description: {
    //   type: String,
    //   required: [true, "Please add a description"],
    //   maxlength: [500, "Description can not be more than 500 characters"],
    // },
    // website: {
    //   type: String,
    //   match: [
    //     /https?:\/\/(www\.)?[-a-zA-Z0-9@:%._\+~#=]{1,256}\.[a-zA-Z0-9()]{1,6}\b([-a-zA-Z0-9()@:%_\+.~#?&//=]*)/,
    //     "Please use a valid URL with HTTP or HTTPS",
    //   ],
    // },
    govtid: {
      type: String,
      required: [true, "Please add a id"],
      unique: true,
      trim: true,
      maxlength: [50, "Name can not be more than 50 characters"],
    },
    phone: {
      type: String,
      maxlength: [20, "Phone number can not be longer than 20 characters"],
    },
    email: {
      type: String,
      match: [
        /^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/,
        "Please add a valid email",
      ],
    },
    address: {
      type: String,
      required: [true, "Please add an address"],
    },
    //location: {
      // GeoJSON Point
    //   type: {
    //     type: String,
    //     enum: ["Point"],
    //   },
    //   coordinates: {
    //     type: [Number],
    //     index: "2dsphere",
    //   },
    //   formattedAddress: String,
    //   street: String,
    //   city: String,
    //   state: String,
    //   zipcode: String,
    //   country: String,
    // },
    // careers: {
    //   // Array of strings
    //   type: [String],
    //   required: true,
    //   enum: [
    //     "Web Development",
    //     "Mobile Development",
    //     "UI/UX",
    //     "Data Science",
    //     "Business",
    //     "Other"
    //   ]
    // },
    averageRating: {
      type: Number,
      min: [1, "Rating must be at least 1"],
      max: [10, "Rating must can not be more than 10"],
    },
    // averageCost: Number,
    photo: {
      type: String,
      default: "no-photo.jpg",
    },

    createdAt: {
      type: Date,
      default: Date.now,
    },
    user: {
      type: mongoose.Schema.ObjectId,
      ref: "User",
      required: true,
    },
  },
  {
    toJSON: { virtuals: true },
    toObject: { virtuals: true },
  }
);

// Create bootcamp slug from the name
GemployeSchema.pre("save", function (next) {
  this.slug = slugify(this.name, { lower: true });
  next();
});

// Geocode & create location field
// GemployeSchema.pre("save", async function (next) {
//   const loc = await geocoder.geocode(this.address);
//   this.location = {
//     type: "Point",
//     coordinates: [loc[0].longitude, loc[0].latitude],
//     formattedAddress: loc[0].formattedAddress,
//     street: loc[0].streetName,
//     city: loc[0].city,
//     state: loc[0].stateCode,
//     zipcode: loc[0].zipcode,
//     country: loc[0].countryCode,
//   };

  // Do not save address in DB
//   this.address = undefined;
//   next();
// });

// Cascade deleted
GemployeSchema.pre("remove", async function (next) {
  console.log(`Scheme being removed from Gemploye ${this._id}`);
  await this.model("Schemes").deleteMany({ gemploye: this._id });
  next();
});

// Reverse populate with virtuals
GemployeSchema.virtual("schemes", {
  ref: "Schemes",
  localField: "_id",
  foreignField: "gemploye",
  justOne: false,
});

module.exports = mongoose.model("Gemploye", GemployeSchema);